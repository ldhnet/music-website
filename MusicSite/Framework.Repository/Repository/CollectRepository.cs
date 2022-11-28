using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class CollectRepository : Repository<Biz_Collect, int>, ICollectRepository
    {
        public CollectRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
