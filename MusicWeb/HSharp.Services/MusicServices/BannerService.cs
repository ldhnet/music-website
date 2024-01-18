using Framework.Models.Entities;
using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class BannerService : RepositoryFactory, IBannerContract
    { 
       
        public async Task<TData> GetAllBanner()
        {   
            TData<List<Biz_Banner>> tData = new TData<List<Biz_Banner>>();
            tData.Tag = 1;
            var list = await _Repository.FindList<Biz_Banner>();
            tData.Data = list.ToList();
            return tData;
        }

    }
}
