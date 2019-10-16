using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp2.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatingApp2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;

        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        // private readonly ILogger<WeatherForecastController> _logger;

        // public WeatherForecastController(ILogger<WeatherForecastController> logger)
        // {
        //     _logger = logger;
        // }

        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        // IActionResult = sirve para poder regresar http Response 
        public IActionResult GetValues()
        {
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();

            var values = _context.Values.ToList(); // retorna los valores de la BD en forma de lista

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
          
            var value = _context.Values.FirstOrDefault(x => x.Id == id);
          

            if (value == null)
            {
                return NotFound();
            }
           
            return Ok(value);
        }

        
        // [HttpGet]
        // public string Get()
        // {
     

        //     return "mamador";
        // }

    }
}
