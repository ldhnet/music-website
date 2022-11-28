using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http; 
using System.Text; 
using Newtonsoft.Json;
using Framework.Utility.Config; 

namespace Framework.Utility.Helper
{
    public class SessionHelper
    {
        /// <summary>
        /// 写Session
        /// </summary>
        /// <typeparam name="T">Session键值的类型</typeparam>
        /// <param name="key">Session的键名</param>
        /// <param name="value">Session的键值</param>
        public void WriteSession<T>(string key, T value)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }
            IHttpContextAccessor hca = GlobalConfig.ServiceProvider?.GetService<IHttpContextAccessor>();
            if (hca == null)
            {
                return;
            } 
            hca.HttpContext.Session.SetString(key, JsonConvert.SerializeObject(value));
        }

        /// <summary>
        /// 写Session
        /// </summary>
        /// <param name="key">Session的键名</param>
        /// <param name="value">Session的键值</param>
        public void WriteSession(string key, string value)
        {
            WriteSession<string>(key, value);
        }

        /// <summary>
        /// 读取Session的值
        /// </summary>
        /// <param name="key">Session的键名</param>        
        public string GetSession(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return string.Empty;
            }
            IHttpContextAccessor hca = GlobalConfig.ServiceProvider?.GetService<IHttpContextAccessor>();
            if (hca == null)
            {
                return string.Empty;
            }
            var result = string.Empty; 
            if (hca.HttpContext.Session.TryGetValue(key, out var bytes))
            { 
              result = Encoding.UTF8.GetString(bytes);
            }
            return result;
        }

        /// <summary>
        /// 删除指定Session
        /// </summary>
        /// <param name="key">Session的键名</param>
        public void RemoveSession(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }
            IHttpContextAccessor hca = GlobalConfig.ServiceProvider?.GetService<IHttpContextAccessor>();
            if (hca == null)
            {
                return;
            }
            hca.HttpContext.Session.Remove(key);
        }
    }
}
