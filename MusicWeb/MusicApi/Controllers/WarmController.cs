 
using Microsoft.AspNetCore.Mvc;  
namespace MusicApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WarmController : ControllerBase
    { 

        private readonly ILogger<WarmController> _logger; 

        public WarmController(ILogger<WarmController> logger)
        {
            _logger = logger; 
        }
 

        [HttpGet(Name = "Warm")]
        //[ServiceFilter(typeof(MyFilter))]
        public string Get()
        {
            _logger.LogInformation("api ‘§»»");
            return "api ‘§»»";
        }  
    }
}