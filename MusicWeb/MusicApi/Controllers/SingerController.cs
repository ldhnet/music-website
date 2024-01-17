 
using HSharp.Contracts.MusicContracts;
using HSharp.Enum;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 

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
        public async Task<TData> AddSinger([FromBody] SingerRequest request)
        {
            var result =await _singerContract.AddSinger(request);
            return result;
        }
        /// <summary>
        /// 删除歌手
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/singer/delete")]
        public async Task<TData> DelSinger(int id)
        {
            var result =await _singerContract.DeleteSinger(id);
            return result;
        }
        /// <summary>
        /// 返回所有歌手
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/singer")]
        public async Task<TData> AllSinger()
        {
            var result =await _singerContract.AllSinger();
            return result;
        }
        /// <summary>
        /// 根据歌手名查找歌手
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/singer/name/detail")]
        public async Task<TData> SingerOfName(string name)
        {
            var result = await _singerContract.SingerOfName(name);
            return result;
        }

        /// <summary>
        /// 根据歌手性别查找歌手
        /// </summary>
        /// <param name="sex"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/singer/sex/detail")]
        public async Task<TData> SingerOfSex(int sex)
        {
            var result =await _singerContract.SingerOfSex(sex);
            return result;
        }

        /// <summary>
        /// 更新歌手信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/singer/update")]
        public async Task<TData> UpdateSinger([FromBody] SingerRequest request)
        {
            var result =await _singerContract.UpdateSingerMsg(request);
            return result;
        }


        /// <summary>
        /// 更新歌手头像
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/singer/avatar/update")]
        public async Task<TData> UpdateSingerPic([FromForm] IFormCollection formCollection, int id)
        {
            TData obj = new TData();
            obj.Tag = 1;
            var files = formCollection.Files;  
            if (!files.Any() || id == 0)
            {
                return obj;
            }
            var result = new FileMusicHelper().SaveFile(WebFilePath.SingerPic, files);
            if (result.Item1)
            {
                var imgPic = result.Item2.FirstOrDefault();
                var ret =await _singerContract.UpdateSingerPic(id, imgPic);
                return ret;
            }
            return obj;
        }

        
    }
}
