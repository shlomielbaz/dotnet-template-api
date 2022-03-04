using DT.Domain.General;

namespace DT.Domain.Models
{
    public class WeatherForecastViewModel
    {
        public string Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string? Summary { get; set; }
    }
}