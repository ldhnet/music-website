using HSharp.Cache.Factory;
using HSharp.Contracts.MusicContracts;

namespace HSharp.Services.MusicServices
{
    public class SystemService : ISystemContract
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
