using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class ListSongController : ControllerBase
    {

        private readonly IListSongContract _listSongContract;

        public ListSongController(IListSongContract listSongContract)
        {
            _listSongContract = listSongContract;
        }
        /// <summary>
        /// 给歌单添加歌曲
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/listSong/add")]
        public IActionResult AddListSong([FromBody] ListSongRequest request)
        {
            var result = _listSongContract.AddListSong(request);
            return Ok(result);
        }
        /// <summary>
        /// 删除歌单里的歌曲
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/listSong/delete")]
        public IActionResult DelListSong(int songId)
        {
            var result = _listSongContract.DeleteListSong(songId);
            return Ok(result);
        }
        /// <summary>
        /// 返回歌单里指定歌单 ID 的歌曲
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/listSong/detail")]
        public IActionResult ListSongOfSongId(int songListId)
        {
            var result = _listSongContract.ListSongOfSongId(songListId);
            return Ok(result);
        }

        /// <summary>
        /// 更新歌单里面的歌曲信息
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/listSong/update")]
        public IActionResult UpdateListSongMsg(ListSongRequest request)
        {
            var result = _listSongContract.UpdateListSongMsg(request);
            return Ok(result);
        }

    }
}
