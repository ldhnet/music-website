using Microsoft.AspNetCore.Mvc;
using Framework.Admin.Contracts;

namespace MusicApi.Controllers
{ 
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly ILogger<BannerController> _logger;

        private readonly IBannerContract _bannerContract;
         
        public BannerController(ILogger<BannerController> logger, IBannerContract bannerContract)
        {
            _logger = logger;
            _bannerContract = bannerContract;
        }
        /// <summary>
        /// 获取Banner图
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/banner/getAllBanner")]
        public IActionResult GetAllBanner()
        {
            return Ok(_bannerContract.GetAllBanner()); 
        }
    }
}
