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
    public interface IRankListContract
    {
        TData AddRank(RankListRequest dto);

        TData RankOfSongListId(int songListId);

        TData GetUserRank(int consumerId, int songListId);
    }
}
