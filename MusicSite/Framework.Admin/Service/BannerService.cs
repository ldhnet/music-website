using Framework.Models.Entities;
using Framework.Repository;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts; 

namespace Framework.Admin.Service
{
    public class BannerService: IBannerContract
    {
        private IBannerRepository _bannerRepository;

        public BannerService(IBannerRepository bannerRepository)
        {
            this._bannerRepository = bannerRepository;
        }
       
        public TData<List<Biz_Banner>> GetAllBanner()
        {   
            TData<List<Biz_Banner>> tData = new TData<List<Biz_Banner>>(); 
            tData.data = _bannerRepository.EntitiesAsNoTracking.ToList();  
            return tData;
        }

    }
}
