using DT.Data;
using DT.Domain.Entities;
using DT.Domain.Interfaces;

namespace DT.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        private readonly IRepository<DataContext> _db;

        public WeatherForecastService(IRepository<DataContext> db)
        {
            _db = db;
        }


        public void Add(WeatherForecast model)
        {
            throw new NotImplementedException();
        }

        public void Delete(WeatherForecast model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }

        public WeatherForecast Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(WeatherForecast model)
        {
            throw new NotImplementedException();
        }
    }
}
