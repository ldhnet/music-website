using HSharp.Contracts.MusicContracts;
using HSharp.Services.MusicServices;
using Microsoft.AspNetCore.Mvc;

namespace MusicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICollectContract _collectContract;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _collectContract = new CollectService();
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<object>> Get()
        {
            var list =await _collectContract.CollectionOfUser(26);
            return Enumerable.Range(1, 5).Select(index => new 
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
