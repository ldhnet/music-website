using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection; 
using Framework.Utility.Config;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Json;

namespace Framework.Cache
{
    public class DistributedCacheImp :ICache
    { 
        /// <summary>
        /// 分布式内存缓存
        /// </summary>
        private IDistributedCache cache = GlobalConfig.ServiceProvider!.GetService<IDistributedCache>()!;

        public bool SetCache<T>(string key, T value, DateTime? expireTime = null)
        { 
            try
            {
                bool isAbsoluteExpiration = false;
                if (expireTime == null)
                { 
                    expireTime = DateTime.MaxValue;
                }
                var expiration = expireTime - DateTime.Now;
                var options = this.BuildDistributedCacheEntryOptions(expiration, isAbsoluteExpiration);
                var setValue = JsonSerializer.SerializeToUtf8Bytes(value);
                cache.Set(key, setValue, options);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public T GetCache<T>(string key)
        {
            var data = cache.Get(key);
            if (data == null)
            {
                return default;
            }
            else
            {
                return JsonSerializer.Deserialize<T>(data);
            }
        }

        public bool RemoveCache(string key)
        {
            cache.Remove(key);
            return true;
        }
        //public bool TryGetValue<T>(string key, out T result)
        //{
        //    var data = cache.Get(key);
        //    if (data == null)
        //    {
        //        result = default;
        //        return false;
        //    }
        //    else
        //    {
        //        result = JsonSerializer.Deserialize<T>(data);
        //        return true;
        //    }
        //}

        public async Task SetAsync(string key, byte[] value, object expiration = null, bool isAbsoluteExpiration = false)
        {
            var options = this.BuildDistributedCacheEntryOptions(expiration, isAbsoluteExpiration);
            await cache.SetAsync(key, value, options);
        }

        public async Task SetAsync(string key, string value, object expiration = null, bool isAbsoluteExpiration = false)
        {
            var options = this.BuildDistributedCacheEntryOptions(expiration, isAbsoluteExpiration);
            await cache.SetStringAsync(key, value, options);
        }  

        public byte[]  GetCache(string key)
        {
            var value = cache.Get(key);
            return value;
        }

        public async Task<byte[]> GetCacheAsync(string key)
        {
            var value = await cache.GetAsync(key);
            return value;
        }
         
        private DistributedCacheEntryOptions BuildDistributedCacheEntryOptions(object expiration = null, bool isAbsoluteExpiration = false)
        {
            var options = new DistributedCacheEntryOptions();
            if (expiration != null)
            {
                if (expiration is TimeSpan)
                {
                    if (isAbsoluteExpiration)
                        options.SetAbsoluteExpiration((TimeSpan)expiration);
                    else
                        options.SetSlidingExpiration((TimeSpan)expiration);
                }
                else if (expiration is DateTimeOffset)
                {
                    options.SetAbsoluteExpiration((DateTimeOffset)expiration);
                }
                else
                {
                    throw new NotSupportedException("Not support current expiration object settings.");
                }
            }
            return options;
        }
         
    }
}
