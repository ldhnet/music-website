
using HSharp.Models.Request;
using HSharp.Util.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HSharp.Contracts.MusicContracts
{
    public interface IRankListContract
    {
        Task<TData> AddRank(RankListRequest dto);

        Task<TData> RankOfSongListId(int songListId);

        Task<TData> GetUserRank(int consumerId, int songListId); 
    }
}
