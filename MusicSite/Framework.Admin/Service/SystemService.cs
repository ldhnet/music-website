using Framework.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts;

namespace Framework.Admin.Service
{
    public class SystemService:ISystemContract
    {
        public DateTime GetCurrentMonth()
        {
            var cacheDate = CacheFactory.Cache.GetCache<string>("CurrentMonth");

            if (string.IsNullOrEmpty(cacheDate))
            {
                cacheDate = DateTime.Now.ToString("yyyy-MM-dd");
                CacheFactory.Cache.SetCache("CurrentMonth", cacheDate);
            }
            return Convert.ToDateTime(cacheDate);
        }

        public int GetCurrentID()
        {
            var CurrentID = CacheFactory.Cache.GetCache<string>("CurrentID");

            if (string.IsNullOrEmpty(CurrentID))
            {
                CurrentID = DateTime.Now.Year.ToString();
                CacheFactory.Cache.SetCache("CurrentID", CurrentID);
            }
            return Convert.ToInt32(CurrentID);
        } 
    }
}
