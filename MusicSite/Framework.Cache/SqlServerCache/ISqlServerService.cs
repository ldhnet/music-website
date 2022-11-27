using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Cache
{
    public interface ISqlServerService
    {
        Task SetAsync(string key, byte[] value, object expiration = null, bool isAbsoluteExpiration = false);

        Task SetAsync(string key, string value, object expiration = null, bool isAbsoluteExpiration = false);

        Task<byte[]> GetAsync(string key);

        Task<string> GetStringAsync(string key);

        Task RemoveAsync(string key);

        Task RefreshAsync(string key);
    }
}
