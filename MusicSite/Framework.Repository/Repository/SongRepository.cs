using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class SongRepository : Repository<Biz_Song, int>, ISongRepository
    {
        public SongRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
