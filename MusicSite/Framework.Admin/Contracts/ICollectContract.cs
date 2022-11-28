using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Admin.Contracts
{
    public interface ICollectContract
    {
        TData AddCollection(CollectRequest addCollectRequest);

        TData ExistSongId(CollectRequest isCollectRequest);

        TData DeleteCollect(int userId, int songId);

        Task<TData> CollectionOfUser(int userId);
    }
}
