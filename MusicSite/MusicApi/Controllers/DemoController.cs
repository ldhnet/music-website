using Framework.Models;
using Framework.Models.Entities;
using Framework.Utility.Extensions;
using Framework.Utility.Security;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Diagnostics;
using Framework.Admin.Contracts; 
using MusicApi.Attributes; 

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
            var aaaa = SecurityHelper.Encrypt(a);
            var bbbb = SecurityHelper.Decrypt(aaaa);

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ldh.docx");
            var filepath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ldh2.docx");
            var filepath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ldh3.docx");

            filepath.CheckFileExists("ldhdd");
            SecurityHelper.EncryptFile(filepath, filepath2);
            SecurityHelper.DecryptFile(filepath2, filepath3); 
        }

    }
}
