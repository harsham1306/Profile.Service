using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Profile.Service.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> resultList = new List<User>()
         {
            new User() { Id = "1", FirstName = "Bill", LastName = "Smith" },
            new User() { Id = "2", FirstName = "Bill", LastName = "Smith" },
            new User() { Id = "3", FirstName = "Bill", LastName = "Smith" },
            new User() { Id = "4", FirstName = "Bill", LastName = "Smith" }
         };
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UsersController> _logger;

        private readonly UsersService _usersService;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
            // _usersService = usersService;
        }

        [HttpGet]
        [Route("api/WeatherForecast")]
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
        [Route("api/Users")]

        public List<User> GetUsersList()
        {
            return resultList;
        }

    }
}
