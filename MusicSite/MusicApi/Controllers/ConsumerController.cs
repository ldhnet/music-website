using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using Framework.Admin.Contracts;

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
        public IActionResult AddUser([FromBody] ConsumerRequest request)
        {
            var result = _consumerContract.AddUser(request);
            return Ok(result);
        }
        /// <summary>
        ///  登录判断
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/login/status")]
        public IActionResult UserLogin([FromBody] ConsumerRequest loginRequest)
        {
            var result = _consumerContract.LoginStatus(loginRequest);
            return Ok(result);
        }

        /// <summary>
        /// 返回所有用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/user")]
        public IActionResult AllUser()
        {
            var result = _consumerContract.AllUser();
            return Ok(result);
        }
        /// <summary>
        /// 返回指定 ID 的用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/user/detail")]
        public IActionResult UserOfId(int id)
        {
            var result = _consumerContract.UserOfId(id);
            return Ok(result);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/user/delete")]
        public IActionResult DelUser(int id)
        {
            var result = _consumerContract.DeleteUser(id);
            return Ok(result);
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/update")]
        public IActionResult UpdateUser([FromBody] ConsumerRequest request)
        {
            var result = _consumerContract.UpdateUserMsg(request);
            return Ok(result);
        }
        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/updatePassword")]
        public IActionResult UpdateUserPwd([FromBody] ConsumerRequest request)
        {
            var result = _consumerContract.UpdatePassword(request);
            return Ok(result);
        }

        /// <summary>
        /// 更新用户头像
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/avatar/update")] 
        public IActionResult UpdateUserPic([FromForm] IFormCollection formCollection, int id)
        {
            var files = formCollection.Files;
            if (!files.Any() || id == 0)
            {
                return Ok(new TData(ResultTag.fail));
            }
            var result = new FileHelper().SaveFile(WebFilePath.AvatorImages, files);
            if (result.Item1)
            {
                var imgPic = result.Item2.FirstOrDefault();
                var ret = _consumerContract.UpdateUserAvator(imgPic,id);
                return Ok(ret);
            }
            return Ok(new TData(ResultTag.fail));
        }
    }
}
