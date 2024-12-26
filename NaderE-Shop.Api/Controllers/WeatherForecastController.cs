using Microsoft.AspNetCore.Mvc;

namespace NaderE_Shop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
    {
#pragma warning disable IDE0300 // Simplify collection initialization
        private static readonly string[] Summaries = new[]
#pragma warning restore IDE0300 // Simplify collection initialization
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

#pragma warning disable IDE0052 // Remove unread private members
        private readonly ILogger<WeatherForecastController> _logger = logger;
#pragma warning restore IDE0052 // Remove unread private members

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
