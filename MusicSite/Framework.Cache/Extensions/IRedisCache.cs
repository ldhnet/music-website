using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Cache
{
    public interface IRedisCache
    {

        #region Hash
        int SetHashFieldCache<T>(string key, string fieldKey, T fieldValue);
        int SetHashFieldCache<T>(string key, Dictionary<string, T> dict);
        T GetHashFieldCache<T>(string key, string fieldKey);
        Dictionary<string, T> GetHashFieldCache<T>(string key, Dictionary<string, T> dict);
        Dictionary<string, T> GetHashCache<T>(string key);
        List<T> GetHashToListCache<T>(string key);
        bool RemoveHashFieldCache(string key, string fieldKey);
        Dictionary<string, bool> RemoveHashFieldCache(string key, Dictionary<string, bool> dict);
        #endregion

        bool LockTake(string kay, string token = "");
        bool LockRelease(string kay, string token = "");
    }
}
