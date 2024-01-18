using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request; 
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class AdminService : RepositoryFactory, IAdminContract
    {
        public async Task<TData> AdminLogin(LoginRequest request)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1; 
            var result = await _Repository.FindEntity<Biz_Admin>(c=>c.UserName == request.UserName.Trim() && c.Password == request.Password.Trim());
            obj.Data = result.Id > 0;
            obj.Description = result != null && result.Id > 0?"登录成功":"登录失败";
            return obj;
        } 
    }
}
