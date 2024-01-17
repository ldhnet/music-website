using Microsoft.AspNetCore.Mvc;  
using HSharp.Models.Request;
using HSharp.Contracts.MusicContracts;
using HSharp.Util.Model;

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IConsumerContract _consumerContract;
        private readonly IAdminContract _adminContract;
         
        public AccountController(ILogger<AccountController> logger, IConsumerContract consumerContract, IAdminContract adminContract)
        {
            _logger = logger;
            _consumerContract = consumerContract;
            _adminContract = adminContract;
        }

        [HttpPost]
        [Route("api/adminLogin")]
        public async Task<TData> AdminLogin([FromBody] LoginRequest request)
        {
            return await _adminContract.AdminLogin(request);        
        }
        [HttpPost]
        [Route("api/userLogin")]
        public async Task<TData> UserLogin([FromBody] LoginRequest request)
        {
            return await _consumerContract.UserLogin(request); 
        }
  
    }
}
