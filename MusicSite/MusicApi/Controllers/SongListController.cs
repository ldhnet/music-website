using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using Framework.Admin.Contracts;

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
        public IActionResult AddSongList([FromBody] SongListRequest request)
        {
            var result = _songListContract.AddSongList(request);
            return Ok(result);
        }
        /// <summary>
        /// 删除歌单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/songList/delete")]
        public IActionResult DelSongList(int id)
        {
            var result = _songListContract.DeleteSongList(id);
            return Ok(result);
        }

        /// <summary>
        /// 返回所有歌单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/songList")]
        public IActionResult AllSongList()
        {
            var result = _songListContract.AllSongList();
            return Ok(result);
        }

        /// <summary>
        /// 返回指定类型的歌单
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/songList/style/detail")]
        public IActionResult SongListOfStyle(string style)
        {
            var result = _songListContract.LikeStyle(style);
            return Ok(result);
        }

        /// <summary>
        /// 更新歌单信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/songList/update")]
        public IActionResult UpdateSongListMsg([FromBody] SongListRequest request)
        {
            var result = _songListContract.UpdateSongListMsg(request);
            return Ok(result);
        }

        /// <summary>
        /// 更新歌单图片
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/songList/img/update")]
        public IActionResult UpdateSongListPic([FromForm] IFormCollection formCollection, int id)
        { 
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return Ok(new TData(ResultTag.fail));
            }
            var result = new FileHelper().SaveFile(WebFilePath.SongListPic, files);
            if (result.Item1)
            {
                var songUrl = result.Item2.FirstOrDefault();
                var ret = _songListContract.UpdateSongListPic(id, songUrl);
                return Ok(ret);
            }
            return Ok(new TData(ResultTag.fail));
        }
    }
}
