
using HSharp.Contracts.MusicContracts;
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<TData> AddCollection([FromBody] CollectRequest request)
        {
            var result =await _collectContract.AddCollection(request);
            return result;
        }
        /// <summary>
        /// 取消收藏的歌曲
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="songId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/collection/delete")]
        public async Task<TData> DelCollection(int userId,int songId)
        {
            var result = await _collectContract.DeleteCollect(userId, songId);
            return result;
        }
        /// <summary>
        /// 是否收藏歌曲
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/collection/status")]
        public async Task<TData> ExistSongId([FromBody] CollectRequest request)
        {
            var result =await _collectContract.ExistSongId(request);
            return result;
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
