using DT.Domain.Entities;
using DT.Domain.Interfaces;
using DT.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet] // (Name = "GetWeatherForecast")
        public IEnumerable<WeatherForecastViewModel> Get()
        {
            return _service.Get().Select(item => new WeatherForecastViewModel()
            {
                Date = item.Date.ToString("dd/MM/yyyy HH:mm:ss"),
                TemperatureC = item.TemperatureC,
                Summary = item.Summary,
                TemperatureF = item.TemperatureF

            });
        }
    }
}