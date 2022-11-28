using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

namespace MusicApi.Controllers
{
    [ApiController]
    public class SingerController : ControllerBase
    {
        private readonly ISingerContract _singerContract;

        public SingerController(ISingerContract singerContract)
        {
            _singerContract = singerContract;
        }
        /// <summary>
        /// 添加歌手
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/singer/add")]
        public IActionResult AddSinger([FromBody] SingerRequest request)
        {
            var result = _singerContract.AddSinger(request);
            return Ok(result);
        }
        /// <summary>
        /// 删除歌手
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/singer/delete")]
        public IActionResult DelSinger(int id)
        {
            var result = _singerContract.DeleteSinger(id);
            return Ok(result);
        }
        /// <summary>
        /// 返回所有歌手
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/singer")]
        public IActionResult AllSinger()
        {
            var result = _singerContract.AllSinger();
            return Ok(result);
        }
        /// <summary>
        /// 根据歌手名查找歌手
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/singer/name/detail")]
        public IActionResult SingerOfName(string name)
        {
            var result = _singerContract.SingerOfName(name);
            return Ok(result);
        }

        /// <summary>
        /// 根据歌手性别查找歌手
        /// </summary>
        /// <param name="sex"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/singer/sex/detail")]
        public IActionResult SingerOfSex(int sex)
        {
            var result = _singerContract.SingerOfSex(sex);
            return Ok(result);
        }

        /// <summary>
        /// 更新歌手信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/singer/update")]
        public IActionResult UpdateSinger([FromBody] SingerRequest request)
        {
            var result = _singerContract.UpdateSingerMsg(request);
            return Ok(result);
        }


        /// <summary>
        /// 更新歌手头像
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/singer/avatar/update")]
        public IActionResult UpdateSingerPic([FromForm] IFormCollection formCollection, int id)
        { 
            var files = formCollection.Files;  
            if (!files.Any() || id == 0)
            {
                return Ok(new TData(ResultTag.fail));
            } 
            var result =new FileHelper().SaveFile(WebFilePath.SingerPic, files);
            if (result.Item1)
            {
                var imgPic = result.Item2.FirstOrDefault();
                var ret = _singerContract.UpdateSingerPic(id,imgPic);
                return Ok(ret);
            }             
            return Ok(new TData(ResultTag.fail));
        }

        
    }
}
