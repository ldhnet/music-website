using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Cache.SqlServerCache
{
    public static class SqlServeCacheExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDistributedSqlServerCache(options =>
            //{
            //    options.ConnectionString = configuration["SqlServerDistributedCache:ConnectionString"];
            //    options.SchemaName = configuration["SqlServerDistributedCache:SchemaName"];
            //    options.TableName = configuration["SqlServerDistributedCache:TableName"];
            //});
            services.AddTransient<ISqlServerService, SqlServerService>();
            return services;
        }
    }
}
