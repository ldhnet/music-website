 
using HSharp.Contracts.MusicContracts;
using HSharp.Enum;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 

namespace MusicApi.Controllers
{
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongContract _songContract;

        public SongController(ISongContract songContract)
        {
            _songContract = songContract;
        }
        /// <summary>
        /// 添加歌曲
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/add")]
        public async Task<TData> AddSong([FromBody] SongRequest request, IFormFileCollection mpfile)
        {
            var result =await _songContract.AddSong(request, mpfile);
            return result;
        }

        /// <summary>
        /// 删除歌曲
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/song/delete")]
        public async Task<TData> DelSong(int id)
        {
            return await _songContract.DeleteSong(id); 
        } 

        /// <summary>
        /// 返回指定歌手ID的歌曲
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/song/detail")]
        public async Task<TData> SongOfId(int id)
        {
            return await _songContract.SongOfId(id); 
        }

        /// <summary>
        /// 返回指定歌手ID的歌曲
        /// </summary>
        /// <param name="singerId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/song/singer/detail")]
        public async Task<TData> SongOfSingerId(int singerId)
        {
            return await _songContract.SongOfSingerId(singerId); 
        }

        /// <summary>
        /// 返回指定歌手名的歌曲
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/song/singerName/detail")]
        public async Task<TData> SongOfSingerName(string name)
        {
            return await _songContract.SongOfSingerName(name); 
        }

        /// <summary>
        /// 更新歌曲信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/update")]
        public async Task<TData> UpdateSingerMsg([FromBody] SongRequest request)
        {
            return await _songContract.UpdateSongMsg(request); 
        }

        /// <summary>
        /// 更新歌曲图片
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/img/update")]
        public async Task<TData> UpdateSingerPic([FromForm] IFormCollection formCollection, int id)
        {
            TData obj = new TData();
            obj.Tag = 1;
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return obj;
            }
            var result = new FileMusicHelper().SaveFile(WebFilePath.SongPic, files);
            if (result.Item1)
            {
                var imgPic = result.Item2.FirstOrDefault();
                var ret =await _songContract.UpdateSongPic(id, imgPic);
                return ret;
            }
            return obj; 
        }

        /// <summary>
        /// 更新歌曲
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/url/update")]
        public async Task<TData> UpdateSingerUrl([FromForm] IFormCollection formCollection, int id)
        {
            TData obj = new TData();
            obj.Tag = 1;
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return obj;
            }
            var result = new FileMusicHelper().SaveFile(WebFilePath.SongVideo, files);
            if (result.Item1)
            {
                var songUrl = result.Item2.FirstOrDefault();
                var ret = await _songContract.UpdateSongUrl(id, songUrl);
                return ret;
            }
            return obj;
        }
    }
}
