
using HSharp.Models.Request;
using HSharp.Util.Model; 

namespace HSharp.Contracts.MusicContracts
{
    public interface IAdminContract
    {
        Task<TData> AdminLogin(LoginRequest request); 

    }
}
