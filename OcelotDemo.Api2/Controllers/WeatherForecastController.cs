using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OcelotDemo.Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] _summaries = new[]
        {
            "Api2 Freezing", "Api2 Bracing", "Api2 Chilly", "Api2 Cool", "Api2 Mild",
            "Api2 Warm", "Api2 Balmy", "Api2 Hot", "Api2 Sweltering", "Api2 Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = _summaries[rng.Next(_summaries.Length)]
            })
            .ToArray();
        }
    }
}
