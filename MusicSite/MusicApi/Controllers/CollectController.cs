using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;
using Framework.Admin.Service;

namespace MusicApi.Controllers
{
    [ApiController] 
    public class CollectController : ControllerBase
    {
        private readonly ILogger<CollectController> _logger;

        private readonly ICollectContract _collectContract;

        public CollectController(ILogger<CollectController> logger, ICollectContract collectContract)
        {
            _logger = logger;
            _collectContract = collectContract;
        }
        /// <summary>
        /// 添加收藏的歌曲
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/collection/add")]
        public IActionResult AddCollection([FromBody] CollectRequest request)
        {
            var result = _collectContract.AddCollection(request);
            return Ok(result);
        }
        /// <summary>
        /// 取消收藏的歌曲
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="songId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/collection/delete")]
        public IActionResult DelCollection(int userId,int songId)
        {
            var result = _collectContract.DeleteCollect(userId, songId);
            return Ok(result);
        }
        /// <summary>
        /// 是否收藏歌曲
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/collection/status")]
        public IActionResult ExistSongId([FromBody] CollectRequest request)
        {
            var result = _collectContract.ExistSongId(request);
            return Ok(result);
        }
        /// <summary>
        /// 返回的指定用户 ID 收藏的列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/collection/detail")]
        public async Task<TData> CollectionOfUser(int userId)
        {
            return await _collectContract.CollectionOfUser(userId); 
        }
    }
}
