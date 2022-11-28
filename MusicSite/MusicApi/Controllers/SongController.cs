using Framework.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

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
        public IActionResult AddSong([FromBody] SongRequest request, IFormFileCollection mpfile)
        {
            var result = _songContract.AddSong(request, mpfile);
            return Ok(result);
        }

        /// <summary>
        /// 删除歌曲
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/song/delete")]
        public IActionResult DelSong(int id)
        {
            var result = _songContract.DeleteSong(id);
            return Ok(result);
        }
        /// <summary>
        /// 返回所有歌曲
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/song")]
        public IActionResult AllSong()
        {
            var result = _songContract.AllSong();
            return Ok(result);
        }

        /// <summary>
        /// 返回指定歌手ID的歌曲
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/song/detail")]
        public IActionResult SongOfId(int id)
        {
            var result = _songContract.SongOfId(id);
            return Ok(result);
        }

        /// <summary>
        /// 返回指定歌手ID的歌曲
        /// </summary>
        /// <param name="singerId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/song/singer/detail")]
        public IActionResult SongOfSingerId(int singerId)
        {
            var result = _songContract.SongOfSingerId(singerId);
            return Ok(result);
        }

        /// <summary>
        /// 返回指定歌手名的歌曲
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/song/singerName/detail")]
        public IActionResult SongOfSingerName(string name)
        {
            var result = _songContract.SongOfSingerName(name);
            return Ok(result);
        }

        /// <summary>
        /// 更新歌曲信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/update")]
        public IActionResult UpdateSingerMsg([FromBody] SongRequest request)
        {
            var result = _songContract.UpdateSongMsg(request);
            return Ok(result);
        }

        /// <summary>
        /// 更新歌曲图片
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/img/update")]
        public IActionResult UpdateSingerPic([FromForm] IFormCollection formCollection, int id)
        { 
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return Ok(new TData(ResultTag.fail));
            }
            var result = new FileHelper().SaveFile(WebFilePath.SongPic, files);
            if (result.Item1)
            {
                var imgPic = result.Item2.FirstOrDefault();
                var ret = _songContract.UpdateSongPic(id, imgPic);
                return Ok(ret);
            }
            return Ok(new TData(ResultTag.fail)); 
        }

        /// <summary>
        /// 更新歌曲
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/song/url/update")]
        public IActionResult UpdateSingerUrl([FromForm] IFormCollection formCollection, int id)
        {  
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return Ok(new TData(ResultTag.fail));
            }
            var result = new FileHelper().SaveFile(WebFilePath.SongVideo, files);
            if (result.Item1)
            {
                var songUrl = result.Item2.FirstOrDefault();
                var ret = _songContract.UpdateSongUrl(id, songUrl);
                return Ok(ret);
            }
            return Ok(new TData(ResultTag.fail));
        }
    }
}
