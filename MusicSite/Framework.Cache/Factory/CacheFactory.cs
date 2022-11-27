namespace Framework.Cache
{
    public class CacheFactory
    {
        private static ICache cache = null;
        private static readonly object lockHelper = new object();

        public static ICache Cache
        {
            get
            {
                if (cache == null)
                {
                    lock (lockHelper)
                    {
                        if (cache == null)
                        {
                            switch ("Redis")//GlobalContext.SystemConfig.CacheProvider
                            {
                                case "Redis": cache = new RedisCacheImp(); break;
                                case "Distributed": cache = new DistributedCacheImp(); break;
                                default:
                                case "Memory": cache = new MemoryCacheImp(); break;
                            }
                        }
                    }
                }
                return cache;
            }
        }
    }
}
