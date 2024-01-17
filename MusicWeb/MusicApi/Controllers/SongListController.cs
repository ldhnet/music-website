using HSharp.Contracts.MusicContracts;
using HSharp.Enum;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 

namespace MusicApi.Controllers
{
    [ApiController]
    public class SongListController : ControllerBase
    {
        private readonly ISongListContract _songListContract;

        public SongListController(ISongListContract songListContract)
        {
            _songListContract = songListContract;
        }
        /// <summary>
        /// 添加歌单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/songList/add")]
        public async Task<TData> AddSongList([FromBody] SongListRequest request)
        {
            return await _songListContract.AddSongList(request);           
        }
        /// <summary>
        /// 删除歌单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/songList/delete")]
        public async Task<TData> DelSongList(int id)
        {
            return await _songListContract.DeleteSongList(id); 
        }

        /// <summary>
        /// 返回所有歌单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/songList")]
        public async Task<TData> AllSongList()
        {
            return await _songListContract.AllSongList(); 
        }

        /// <summary>
        /// 返回指定类型的歌单
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/songList/style/detail")]
        public async Task<TData> SongListOfStyle(string style)
        {
            return await _songListContract.LikeStyle(style); 
        }

        /// <summary>
        /// 更新歌单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/songList/update")]
        public async Task<TData> UpdateSongListMsg([FromBody] SongListRequest request)
        {
            return await _songListContract.UpdateSongListMsg(request); 
        }

        /// <summary>
        /// 更新歌单图片
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/songList/img/update")]
        public async Task<TData> UpdateSongListPic([FromForm] IFormCollection formCollection, int id)
        {

            TData obj = new TData();
            obj.Tag = 1;
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return obj;
            }
            var result = new FileMusicHelper().SaveFile(WebFilePath.SongListPic, files);
            if (result.Item1)
            {
                var songUrl = result.Item2.FirstOrDefault();
                var ret =await _songListContract.UpdateSongListPic(id, songUrl);
                return ret;
            }
            return obj;
        }
    }
}
