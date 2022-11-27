using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class SongListRepository : Repository<Biz_Song_List, int>, ISongListRepository
    {
        public SongListRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
