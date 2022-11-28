using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory; 
using Framework.Utility.Config; 

namespace Framework.Cache
{
    public class MemoryCacheImp : ICache
    {
        //IMemoryCache
        private IMemoryCache cache = GlobalConfig.ServiceProvider!.GetService<IMemoryCache>()!;

        public bool SetCache<T>(string key, T value, DateTime? expireTime = null)
        {
            try
            {
                if (expireTime == null)
                {
                    return cache.Set<T>(key, value) != null;
                }
                else
                {
                    return cache.Set(key, value, (expireTime.Value - DateTime.Now)) != null;
                }
            }
            catch (Exception ex)
            {
                //LogHelper.Error(ex);
            }
            return false;
        }

        public bool RemoveCache(string key)
        {
            cache.Remove(key);
            return true;
        }

        public T GetCache<T>(string key)
        {
            var value = cache.Get<T>(key);
            return value;
        } 
    }
}
