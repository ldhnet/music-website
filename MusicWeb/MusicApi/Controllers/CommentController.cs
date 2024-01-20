
using HSharp.Contracts.MusicContracts;
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 
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
        public async Task<TData> AddComment([FromBody] CommentRequest request)
        {
            var result =await _commentContract.AddComment(request);
            return result;
        }
        /// <summary>
        ///  删除评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/comment/delete")]
        public async Task<TData> DelComment(int id)
        {
            var result =await _commentContract.DeleteComment(id);
            return result;
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
        /// <param name="id"></param>
        /// <param name="up"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/comment/like")]
        public async Task<TData> CommentOfLike(CommentLike dto)
        {
            var result =await _commentContract.UpdateCommentMsg(dto);
            return result;
        }
    }
}
