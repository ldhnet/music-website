using HSharp.Contracts.MusicContracts;
using HSharp.Enum;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;
using Microsoft.AspNetCore.Mvc; 

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        private readonly ILogger<ConsumerController> _logger;

        private readonly IConsumerContract _consumerContract;

        public ConsumerController(ILogger<ConsumerController> logger, IConsumerContract consumerContract)
        {
            _logger = logger;
            _consumerContract = consumerContract;
        }
        /// <summary>
        ///  用户注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/add")]
        public async Task<TData> AddUser([FromBody] ConsumerRequest request)
        {
            var result =await _consumerContract.AddUser(request);
            return result;
        }
        /// <summary>
        ///  登录判断
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/login/status")]
        public async Task<TData> UserLogin([FromBody] ConsumerRequest loginRequest)
        {
            var result =await _consumerContract.LoginStatus(loginRequest);
            return result;
        }

        /// <summary>
        /// 返回所有用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/user")]
        public async Task<TData> AllUser()
        {
            var result =await _consumerContract.AllUser();
            return result;
        }
        /// <summary>
        /// 返回指定 ID 的用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/user/detail")]
        public async Task<TData> UserOfId(int id)
        {
            var result =await _consumerContract.UserOfId(id);
            return result;
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/user/delete")]
        public async Task<TData> DelUser(int id)
        {
            var result =await _consumerContract.DeleteUser(id);
            return result;
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/update")]
        public async Task<TData> UpdateUser([FromBody] ConsumerRequest request)
        {
            var result =await _consumerContract.UpdateUserMsg(request);
            return result;
        }
        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/updatePassword")]
        public async Task<TData> UpdateUserPwd([FromBody] ConsumerRequest request)
        {
            var result = await _consumerContract.UpdatePassword(request);
            return result;
        }

        /// <summary>
        /// 更新用户头像
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/avatar/update")] 
        public async Task<TData> UpdateUserPic([FromForm] IFormCollection formCollection, int id)
        {
            TData<string> obj = new TData<string>(); 
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                obj.Tag = 0;
                obj.Description = "请选择图片！";
                return obj;
            }
            var result = new FileMusicHelper().SaveFile(WebFilePath.AvatorImages, files);
            if (result.Item1)
            {
                var imgPic = result.Item2.FirstOrDefault();
                var ret = await _consumerContract.UpdateUserAvator(imgPic, id);
                obj.Tag = ret.Tag;
                obj.Data = imgPic?? DefaultSiteFile.defaultImgUrl;
                obj.Description = "图片上传成功！";
                return obj;
            }
            else
            {
                obj.Tag = 0;
                obj.Description = "图片上传失败！";
            }
            return obj;
        }
    }
}
