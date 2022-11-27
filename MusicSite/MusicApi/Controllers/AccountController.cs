using Framework.Models.Request; 
using Microsoft.AspNetCore.Mvc; 
using Framework.Admin.Contracts; 

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        private readonly IServiceProvider _provider; 

        public AccountController(ILogger<AccountController> logger, IServiceProvider provider)
        {
            _logger = logger;
            _provider = provider;
        }

        private IAccountContract _accountContract => GlobalConfig.ServiceProvider.GetRequiredService<IAccountContract>();

        [HttpPost]
        [Route("api/adminLogin")]
        public IActionResult AdminLogin([FromBody] AdminRequest request)
        {
 
            var result = _accountContract.AdminLogin(request);
            if (result.success)
            {
                HttpContext.Session.SetString(CacheKay.SessionUser, request.username);
            } 
            return Ok(result);
        }
        [HttpPost]
        [Route("api/userLogin")]
        public IActionResult UserLogin([FromBody] AdminRequest request)
        {
            var result = _accountContract.UserLogin(request);

            return Ok(result);
        }

        /// <summary>
        /// swagger登录
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Account/swgLogin")]
        public dynamic SwgLogin([FromBody] SwaggerLoginRequest loginRequest)
        {
            _logger.LogInformation("api/Login/swgLogin");
            // 这里可以查询数据库等各种校验
            if (loginRequest?.name == "admin" && loginRequest?.pwd == "admin")
            {
                HttpContext.Session.SetString("swagger-code", "success");

                return new { result = true };
            }
            return new { result = false };
        }
    }
}
