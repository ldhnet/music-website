using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Admin.Contracts; 

namespace Framework.Admin.Service
{
    public class RankListService : IRankListContract
    {
        private IRankListRepository _rankListRepository;

        public RankListService(IRankListRepository rankListRepository)
        {
            _rankListRepository = rankListRepository;
        }

        public TData AddRank(RankListRequest dto)
        {
            var entity = dto.MapTo<Biz_Rank_List>();
            var result = _rankListRepository.Insert(entity);
            return result > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }

        public TData GetUserRank(int consumerId, int songListId)
        {
            int rankScore = 0;
            var list = _rankListRepository.QueryAsNoTracking(c =>c.consumerId == consumerId && c.songListId == songListId).ToList();
            if (list.Any())
            {
                rankScore = list.Sum(c => c.score);
            }
            return new TData(ResultTag.success, OperateMsg.OptSuccess, rankScore);
        }

        public TData RankOfSongListId(int songListId)
        {
            int rankScore = 0;
            var list = _rankListRepository.QueryAsNoTracking(c => c.songListId == songListId).ToList();
            if (list.Any())
            {
                rankScore = list.Sum(c => c.score);
            }
            return new TData(ResultTag.success, OperateMsg.OptSuccess, rankScore);
        }
    }
}
