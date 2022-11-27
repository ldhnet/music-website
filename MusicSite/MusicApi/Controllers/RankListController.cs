using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

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
        public IActionResult AddRank([FromBody] RankListRequest request)
        {
            var result = _rankListContract.AddRank(request);
            return Ok(result);
        }
        /// <summary>
        /// 获取指定歌单的评分
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("/rankList")]
        public IActionResult RankOfSongListId(int songListId)
        {
            var result = _rankListContract.RankOfSongListId(songListId);
            return Ok(result);
        }


        [HttpGet]
        [Route("/rankList/user")]
        public IActionResult GetUserRank(int consumerId,int songListId)
        {
            var result = _rankListContract.GetUserRank(consumerId, songListId);
            return Ok(result);
        }
    }
}
