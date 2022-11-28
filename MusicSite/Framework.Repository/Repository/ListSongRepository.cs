using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public class ListSongRepository : Repository<Biz_List_Song, int>, IListSongRepository
    {
        public ListSongRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
