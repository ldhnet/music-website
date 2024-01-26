
using HSharp.Contracts.MusicContracts;
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class RankListController : ControllerBase
    {

        private readonly IRankListContract _rankListContract;

        public RankListController(IRankListContract rankListContract)
        {
            _rankListContract = rankListContract;
        }
        /// <summary>
        /// 提交评分获取指定歌单的评分
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/rankList/add")]
        public async Task<TData> AddRank([FromBody] RankListRequest request)
        {
            var result =await _rankListContract.AddRank(request);
            return result;
        }
        /// <summary>
        /// 获取指定歌单的评分
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("/rankList")]
        public async Task<TData> RankOfSongListId(int songListId)
        {
            var result =await _rankListContract.RankOfSongListId(songListId);
            return result;
        }

        /// <summary>
        /// 获取指定歌单的评分
        /// </summary>
        /// <param name="consumerId"></param>
        /// <param name="songListId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/rankList/user")]
        public async Task<TData> GetUserRank(int consumerId,int songListId)
        {
            var result = await _rankListContract.GetUserRank(consumerId, songListId);
            return result;
        }
    }
}
