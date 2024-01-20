 
using Microsoft.AspNetCore.Mvc; 
using HSharp.Models.Request;
using HSharp.Contracts.MusicContracts;
using HSharp.Util.Model;

namespace MusicApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserSupportController : ControllerBase
    {
        private readonly IUserSupportContract _userSupportContract;

        public UserSupportController(IUserSupportContract userSupportContract)
        {
            _userSupportContract = userSupportContract;
        }

        [HttpPost]
        [Route("/userSupport/test")]
        public async Task<TData> IsUserSupportComment([FromBody] UserSupportRequest request)
        {
            return await _userSupportContract.IsUserSupportComment(request); 
        }

        [HttpPost]
        [Route("/userSupport/insert")]
        public async Task<TData> InsertCommentSupport([FromBody] UserSupportRequest request)
        {
            return await _userSupportContract.InsertCommentSupport(request);
          
        }

        [HttpPost]
        [Route("/userSupport/delete")]
        public async Task<TData> DeleteCommentSupport([FromBody] UserSupportRequest request)
        {
            return await _userSupportContract.DeleteCommentSupport(request); 
        }
    }
}
