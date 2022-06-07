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

        public string GetStringReverse(string str)
        {
            //string str = "Nisha";
            //char[] cArr = new char[str.Length];
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

        [HttpGet]
        [Route("/GetFibonacci")]
        public int[] GetFibonacci(int limit)
        {
            int a = 0,b = 1,temp;
            int[] fib = new int[limit];
            fib[0] = a;
            fib[1] = b;

            Console.Write(a + " " + b);

            for (int i = 2; i < limit; i++)
            {
                temp = a + b;
                fib[i] = temp;
                Console.Write(" " + temp);
                a = b;
                b = temp;
            }
            return fib;
        }

    }
}
