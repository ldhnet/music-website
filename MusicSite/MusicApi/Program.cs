using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Framework.EF.Context; 
using Framework.Repository;
using Framework.Utility;
using Framework.Utility.Dependency; 
using MusicApi.Attributes;
using MusicApi.Filter;
using MusicApi.Middleware;
using Lee.Mapper;


var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:9010");//切记要用* 而不要用localhost 否则docker 无法运行 会链接被重置错误
// Add services to the container.
 
builder.Host.UseContentRoot(Directory.GetCurrentDirectory());
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    var env = hostingContext.HostingEnvironment;
    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
    config.AddEnvironmentVariables();
});

 
//kestrel限制请求体最大为：28M；
//formbody最大为：128M
//解除kestrel限制
builder.WebHost.ConfigureKestrel(options =>
{
    //options.Limits.MaxRequestBodySize = 30000000L;//默认约28M
    //options.Limits.MaxRequestBodySize = 2 * 2L << 30;//指定最大2G
    options.Limits.MaxRequestBodySize = null;//去掉限制 仅用于演示
});

//解除 formbody限制
builder.Services.Configure<FormOptions>(x =>
{
    //x.MultipartBodyLengthLimit = 134217728;//文件上传 默认128MB
    x.MultipartBodyLengthLimit = 5 * 2L << 30;//这里手动设置为5GB,这么大的数值仅用于演示

    x.ValueLengthLimit = 209715200;//200MB   //.netcore 限制了每个 POST 数据值的长度为 4M  提升到200M
});

builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = 209715200;//200MB   //.netcore 限制了每个 POST 数据值的长度为 4M  提升到200M
});


builder.Services.AddControllers(options =>
{
    options.ModelMetadataDetailsProviders.Add(new ModelBindingMetadataProvider());
}).AddNewtonsoftJson(options =>
{
    // 返回数据首字母不小写，CamelCasePropertyNamesContractResolver是小写
    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
});

builder.Services.AddEndpointsApiExplorer();
 
builder.Services.AddDistributedMemoryCache();

//部署同一服务器 
builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(builder.Environment.ContentRootPath + Path.DirectorySeparatorChar + "DataProtection"));
 
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


#region 注册Session服务
// 注册Session服务
builder.Services.AddSession(options =>
{
    options.Cookie.Name = "LDH.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(30 * 60);//设置session的过期时间 单位秒
    options.Cookie.HttpOnly = true;//设置在浏览器不能通过js获得该cookie的值
});

#endregion 使用Redis保存Session

#region 跨域

builder.Services.AddCors(options => options.AddPolicy("AllowSameDomain", builder => builder.SetIsOriginAllowed(_ => true).AllowCredentials().AllowAnyMethod().AllowAnyHeader()));

#endregion 跨域

#region Swagger Config
builder.Services.AddSwaggerGen(options => {

    options.SwaggerDoc("v1", new() { Title = "Music-Server", Version = "v1" });

    // 配置 Swagger 认证信息
    options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Description = "JWT Authorization header using the Bearer scheme."
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "bearer" }
            },
            new string[] {}
        }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var filePath = Path.Combine(AppContext.BaseDirectory, xmlFilename);
    options.IncludeXmlComments(filePath);
});

#endregion 

builder.Services.AddDbContextPool<MyDBContext>(options =>
{
    //var connection = "server=127.0.0.1;userid=root;pwd=123456;port=3306;database=tp_music;Allow User Variables=True;sslMode=None";
    var connection = "server=sh-cynosdbmysql-grp-brbuc2xq.sql.tencentcdb.com;userid=root;pwd=Dsb0004699;port=21952;database=tp_music;Allow User Variables=True;sslMode=None";
    options.UseMySql(connection, ServerVersion.Create(8, 0, 22, ServerType.MySql));
}, 60);
 
builder.Services.AddScoped<MyFilter>();
builder.Services.AddScoped<MyDBContext>();
#region Autofac

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    //builder.RegisterType<MyDBContext>().AsSelf().InstancePerLifetimeScope(); 
    builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

    Type baseType = typeof(IDependency);
    var assemblieTypes = Assembly.GetEntryAssembly()?.GetReferencedAssemblies()
    .Select(Assembly.Load)
    .SelectMany(c => c.GetExportedTypes())
    .Where(t => baseType.IsAssignableFrom(t))
    .ToArray();
    builder.RegisterTypes(assemblieTypes).AsSelf().InstancePerLifetimeScope(); //保证生命周期基于请求
      
    var assemblies = Assembly.GetEntryAssembly()?//获取默认程序集
            .GetReferencedAssemblies()//获取所有引用程序集
            .Select(Assembly.Load)
            .Where(c => c.FullName!.Contains("Framework.Admin", StringComparison.OrdinalIgnoreCase) || c.FullName!.Contains("Framework.Repository", StringComparison.OrdinalIgnoreCase))
            .ToArray();
    builder.RegisterAssemblyTypes(assemblies!)
        .Where(type => !type.IsAbstract)
        .AsSelf()   //自身服务，用于没有接口的类
        .AsImplementedInterfaces()  //接口服务
        .PropertiesAutowired()  //属性注入
        .InstancePerLifetimeScope(); //保证生命周期基于请求

    //支持属性注入
    var controllerBaseType = typeof(ControllerBase);
    builder.RegisterAssemblyTypes(typeof(Program).Assembly)
    .Where(t => controllerBaseType.IsAssignableFrom(t) && t != controllerBaseType)
    .PropertiesAutowired(new CustomPropertySelector());//支持属性注入
});

//支持容器的实例让IOC容器创建--autofac来创建
builder.Services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());

#endregion Autofac

//builder.Services.AddHangfire(builder.Configuration);

builder.Services.AddAutoMapper(MapperRegister.MapType());

GlobalConfig.Services = builder.Services;
GlobalConfig.Configuration = builder.Configuration;
//GlobalConfig.HostEnvironment = builder.Environment;
GlobalConfig.WebRootPath = builder.Environment.WebRootPath;

var app = builder.Build(); 
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseCookiePolicy();
app.UseSession(); 
app.UseSwaggerAuthorized();
app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseCors("AllowSameDomain");
//app.UseMiddleware(typeof(VisitRecordMiddleware));
app.UseMiddleware(typeof(GlobalExceptionMiddleware));
app.UseAuthorization();
app.MapControllers();
app.UseStateAutoMapper();

GlobalConfig.ServiceProvider = app.Services;
var url = GlobalConfig.Configuration[WebHostDefaults.ServerUrlsKey];
GlobalConfig.HostUrl = url.Contains("*") ? url.Replace("*", "127.0.0.1") : url;

//api 预热
app.Lifetime.ApplicationStarted.Register(() => {
    //GlobalConfig.LogWhenStart(GlobalConfig.HostEnvironment);
    var warm = GlobalConfig.HostUrl.Split(';')[0] + "/Warm/Get";
    new HttpClient().GetAsync(warm).Wait();
});
 
app.Run();


