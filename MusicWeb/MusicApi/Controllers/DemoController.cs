
using HSharp.Util;
using Microsoft.AspNetCore.Mvc; 
namespace MusicApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;  
        private readonly IServiceProvider _provider; 
        public DemoController(ILogger<DemoController> logger, IHost host)
        {
            _logger = logger;
            _provider = host.Services; 
        }
           
     
        private void AesTest()
        {
            var a = "123";
            var aaaa = SecurityHelper.AESEncrypt(a);
            var bbbb = SecurityHelper.AESDecrypt(aaaa);

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ldh.docx");
            var filepath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ldh2.docx");
            var filepath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ldh3.docx");

            //filepath.CheckFileExists("ldhdd");
            //SecurityHelper.e(filepath, filepath2);
            //SecurityHelper.DecryptFile(filepath2, filepath3); 
        }

    }
}
