using Framework.Models.Entities;
using Framework.Repository.Data;
using Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Framework.Repository
{
    public class AdminRepository : Repository<Biz_Admin, int>, IAdminRepository
    {
        public AdminRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
