using Autofac;
using Autofac.Extensions.DependencyInjection;
using HSharp.Mapper;
using HSharp.Util;
using HSharp.Util.Model;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using MusicApi.Filter;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Text; 
var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:9011");//切记要用* 而不要用localhost 否则docker 无法运行 会链接被重置错误

GlobalContext.HostEnvironment = builder.Environment;
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
       .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
builder.Configuration.AddEnvironmentVariables();
 
builder.Services.AddSwaggerGen(options =>
{
    var xmlPath = Path.Combine(GlobalContext.HostEnvironment?.ContentRootPath!, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");//AppContext.BaseDirectory
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "MusicWeb Api", Version = "v1" });
    options.IncludeXmlComments(xmlPath, true);
});

builder.Services.AddOptions();
builder.Services.AddCors();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[] { "zh-CN","en-US" };
    options.SetDefaultCulture(supportedCultures[0])
        .AddSupportedCultures(supportedCultures)
        .AddSupportedUICultures(supportedCultures);
});
builder.Services.AddControllers(options =>
{
    options.ModelMetadataDetailsProviders.Add(new ModelBindingMetadataProvider());
}).AddNewtonsoftJson(options =>
{
    // 返回数据首字母不小写，CamelCasePropertyNamesContractResolver是小写
    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMemoryCache();

builder.Services.AddAutoMapper(MapperRegister.MapType());
 
#region Autofac

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{ 
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
            .Where(c => c.FullName!.Contains("HSharp.Services", StringComparison.OrdinalIgnoreCase) || c.FullName!.Contains("HSharp.Contracts", StringComparison.OrdinalIgnoreCase))
            .ToArray();
    builder.RegisterAssemblyTypes(assemblies!)
        .Where(type => !type.IsAbstract)
        .AsSelf()   //自身服务，用于没有接口的类
        .AsImplementedInterfaces()  //接口服务
        .PropertiesAutowired()  //属性注入
        .InstancePerLifetimeScope(); //保证生命周期基于请求 
});


#endregion Autofac

builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(GlobalContext.HostEnvironment?.ContentRootPath + Path.DirectorySeparatorChar + "DataProtection"));
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);  // 注册Encoding

GlobalContext.SystemConfig = builder.Configuration.GetSection("SystemConfig").Get<SystemConfig>()!;
GlobalContext.Services = builder.Services;
GlobalContext.Configuration = builder.Configuration;

 

var app = builder.Build();
 
if (app.Environment.IsDevelopment())
{
    GlobalContext.SystemConfig.Debug = true;
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseDeveloperExceptionPage();
}

string resource = Path.Combine(app.Environment.ContentRootPath, "wwwroot");
FileHelper.CreateDirectory(resource);

app.UseStaticFiles(new StaticFileOptions
{
    RequestPath = "/wwwroot",
    FileProvider = new PhysicalFileProvider(resource),
    OnPrepareResponse = GlobalContext.SetCacheControl
});

app.UseMiddleware(typeof(GlobalExceptionMiddleware));

app.UseStateAutoMapper();

app.UseCors(builder =>
{
    builder.WithOrigins(GlobalContext.SystemConfig.AllowCorsSite.Split(',')).AllowAnyHeader().AllowAnyMethod().AllowCredentials();
});
app.UseSwagger(c =>
{
    c.RouteTemplate = "api-doc/{documentName}/swagger.json";
});
app.UseSwaggerUI(c =>
{
    c.RoutePrefix = "api-doc";
    c.SwaggerEndpoint("v1/swagger.json", "MusicWeb Api v1");
});
app.UseRouting();
 
GlobalContext.ServiceProvider = app.Services;

app.MapControllers();

var url = GlobalContext.Configuration[WebHostDefaults.ServerUrlsKey];
GlobalContext.HostUrl = url.Contains("*") ? url.Replace("*", "127.0.0.1") : url;

//api 预热
app.Lifetime.ApplicationStarted.Register(() => {
    //GlobalConfig.LogWhenStart(GlobalConfig.HostEnvironment);
    var warm = GlobalContext.HostUrl.Split(';')[0] + "/Warm/Get";
    new HttpClient().GetAsync(warm).Wait();
});
app.Run();
