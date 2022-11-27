using Framework.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

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
        [Route("/test")]
        public IActionResult IsUserSupportComment([FromBody] UserSupportRequest request)
        {
            var result = _userSupportContract.IsUserSupportComment(request);
            return Ok(result);
        }

        [HttpPost]
        [Route("/insert")]
        public IActionResult InsertCommentSupport([FromBody] UserSupportRequest request)
        {
            var result = _userSupportContract.InsertCommentSupport(request);
            return Ok(result);
        }

        [HttpPost]
        [Route("/delete")]
        public IActionResult DeleteCommentSupport([FromBody] UserSupportRequest request)
        {
            var result = _userSupportContract.DeleteCommentSupport(request);
            return Ok(result);
        }
    }
}
