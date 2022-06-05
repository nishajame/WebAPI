using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("/GetStringReverse")]

        public string GetStringReverse()
        {
            string str = "Nisha";
            char[] cArr = new char[str.Length];
            //int j = 0;
            string strRev = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                strRev = strRev + str[i];
                //j++;
            }
           
            return strRev;
        }

        [HttpGet]
        [Route("/GetFactorial")]
        public int GetFactorial(int num)
        {
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        } 

       
    }
}
