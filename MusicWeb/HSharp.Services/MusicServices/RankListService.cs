using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class RankListService : RepositoryFactory, IRankListContract
    {
        public async Task<TData> AddRank(RankListRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = dto.MapTo<Biz_Rank_List>();
            var result = await _Repository.Insert(entity);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> GetUserRank(int consumerId, int songListId)
        {
            TData<int> obj = new TData<int>();
            obj.Tag = 1;

            int rankScore = 0;
            var list = await _Repository.FindList<Biz_Rank_List>(c => c.ConsumerId == consumerId && c.SongListId == songListId);
            if (list.Any())
            {
                rankScore = list.Sum(c => c.Score);
            }
            obj.Data = rankScore;
            return obj;
        }

        public async Task<TData> RankOfSongListId(int songListId)
        {
            TData<int> obj = new TData<int>();
            obj.Tag = 1;
            int rankScore = 0;
            var list = await _Repository.FindList<Biz_Rank_List>(c => c.SongListId == songListId);
            if (list.Any())
            {
                rankScore = list.Sum(c => c.Score);
            }
            obj.Data = rankScore;

            return obj;
        }
    }
}
