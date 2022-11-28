using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class BannerRepository : Repository<Biz_Banner, int>, IBannerRepository
    {
        public BannerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
