using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class SingerRepository : Repository<Biz_Singer, int>, ISingerRepository
    {
        public SingerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
