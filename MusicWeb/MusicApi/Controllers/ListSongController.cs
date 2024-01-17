
using HSharp.Contracts.MusicContracts;
using HSharp.Models.Request;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 

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
        public async Task<TData> AddListSong([FromBody] ListSongRequest request)
        {
            var result =await _listSongContract.AddListSong(request);
            return result;
        }
        /// <summary>
        /// 删除歌单里的歌曲
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/listSong/delete")]
        public async Task<TData> DelListSong(int songId)
        {
            var result =await _listSongContract.DeleteListSong(songId);
            return result;
        }
        /// <summary>
        /// 返回歌单里指定歌单 ID 的歌曲
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/listSong/detail")]
        public async Task<TData> ListSongOfSongId(int songListId)
        {
            var result = await _listSongContract.ListSongOfSongId(songListId);
            return result;
        }

        /// <summary>
        /// 更新歌单里面的歌曲信息
        /// </summary>
        /// <param name="songListId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/listSong/update")]
        public async Task<TData> UpdateListSongMsg(ListSongRequest request)
        {
            var result = await _listSongContract.UpdateListSongMsg(request);
            return result;
        }

    }
}
