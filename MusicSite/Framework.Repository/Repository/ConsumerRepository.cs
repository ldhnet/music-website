using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class ConsumerRepository : Repository<Biz_Consumer, int>, IConsumerRepository
    {
        public ConsumerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
