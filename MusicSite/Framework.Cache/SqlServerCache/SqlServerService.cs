using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Cache
{ 
    public class SqlServerService : ISqlServerService
    {
        private readonly IDistributedCache _cacheService;

        public SqlServerService(IDistributedCache cacheService)
        {
            this._cacheService = cacheService;
        }

        public async Task SetAsync(string key, byte[] value, object expiration = null, bool isAbsoluteExpiration = false)
        {
            var options = this.BuildDistributedCacheEntryOptions(expiration, isAbsoluteExpiration);
            await _cacheService.SetAsync(key, value, options);
        }

        public async Task SetAsync(string key, string value, object expiration = null, bool isAbsoluteExpiration = false)
        {
            var options = this.BuildDistributedCacheEntryOptions(expiration, isAbsoluteExpiration);
            await _cacheService.SetStringAsync(key, value, options);
        }

        public async Task<byte[]> GetAsync(string key)
        {
            return await _cacheService.GetAsync(key);
        }

        public async Task<string> GetStringAsync(string key)
        {
            return await _cacheService.GetStringAsync(key);
        }

        public async Task RemoveAsync(string key)
        {
            await _cacheService.RemoveAsync(key);
        }

        public async Task RefreshAsync(string key)
        {
            await _cacheService.RefreshAsync(key);
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

    //    public class DistributedCacheEntryOptions
    //    {
    //        public DistributedCacheEntryOptions()
    //public DateTimeOffset? AbsoluteExpiration { get; set; }//绝对过期时间
    //        public TimeSpan? AbsoluteExpirationRelativeToNow { get; set; }//绝对过期时间
    //        public TimeSpan? SlidingExpiration { get; set; } //滑动过期时间（如果在滑动过期时间内刷新，将重新设置滑动过去时间，对应IDistributedCache中的Refresh方法）
    //    }
    }
}
