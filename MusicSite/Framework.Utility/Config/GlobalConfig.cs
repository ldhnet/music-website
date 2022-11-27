using Framework.Utility.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System.Text;

namespace Framework.Utility.Config
{
    public class GlobalConfig
    {
        /// <summary>
        /// All registered service and class instance container. Which are used for dependency injection.
        /// </summary>
        public static IServiceCollection Services { get; set; }
        /// <summary>
        /// Configured service provider.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; set; }

        public static IConfiguration Configuration { get; set; }

        //public static IHostEnvironment HostEnvironment { get; set; }

        public static string WebRootPath { get; set; } 
        public static SystemConfig SystemConfig { get; set; } = new SystemConfig();
        public static MailSenderOptions MailSenderOptions { get; set; } = new MailSenderOptions();
      
        public static string wwwwroot { get { return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"); } }
        public static string RootDirectory { get { return Directory.GetCurrentDirectory(); } }

        public static string HostUrl { get; set; }

        public static string GetVersion()
        {
            Version version = Assembly.GetEntryAssembly()?.GetName().Version??new Version(1,0);
            return version.Major + "." + version.Minor;
        }

        /// <summary>
        /// 程序启动时，记录目录
        /// </summary>
        /// <param name="env"></param>
        //public static void LogWhenStart(IHostEnvironment env)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("程序启动");
        //    sb.Append(" |ContentRootPath:" + env.ContentRootPath);
        //    sb.Append(" |WebRootPath:" + WebRootPath);
        //    sb.Append(" |IsDevelopment:" + env.IsDevelopment());
        //    LogHelper.Debug(sb.ToString());
        //}
    }
}
