
using HSharp.Models.Request;
using HSharp.Util.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Contracts.MusicContracts
{
    public interface IConsumerContract
    {
        Task<TData> UserLogin(LoginRequest request);
        Task<TData> AddUser(ConsumerRequest registryRequest);

        Task<TData> UpdateUserMsg(ConsumerRequest dto);

        Task<TData> UpdateUserAvator(string? avatorFileUrl, int id);

        Task<TData> UpdatePassword(ConsumerRequest updatePasswordRequest);

        Task<TData> ExistUser(string username);
          
        Task<TData> DeleteUser(int id);

        Task<TData> AllUser();

        Task<TData> UserOfId(int id);

        Task<TData> LoginStatus(ConsumerRequest loginRequest);

    }
}
