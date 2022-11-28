using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;

        private readonly ICommentContract _commentContract;

        public CommentController(ILogger<CommentController> logger, ICommentContract commentContract)
        {
            _logger = logger;
            _commentContract = commentContract;
        }
        /// <summary>
        ///  新增评论
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/comment/add")]
        public IActionResult AddComment([FromBody] CommentRequest request)
        {
            var result = _commentContract.AddComment(request);
            return Ok(result);
        }
        /// <summary>
        ///  删除评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/comment/delete")]
        public IActionResult DelComment(int id)
        {
            var result = _commentContract.DeleteComment(id);
            return Ok(result);
        }
        /// <summary>
        /// 获得指定歌曲 ID 的评论列表
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/comment/song/detail")]
        public async Task<TData> CommentOfSongId(int songId)
        {
            var result = await _commentContract.CommentOfSongId(songId);
            return result;
        }
        /// <summary>
        /// 获得指定歌单 ID 的评论列表
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/comment/songList/detail")]
        public async Task<TData> CommentOfSongListId(int songListId)
        {
            var result = await _commentContract.CommentOfSongListId(songListId);
            return result;
        }
        /// <summary>
        /// 点赞
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/comment/like")]
        public IActionResult CommentOfLike([FromBody] CommentRequest request)
        {
            var result = _commentContract.UpdateCommentMsg(request);
            return Ok(result);
        }
    }
}
