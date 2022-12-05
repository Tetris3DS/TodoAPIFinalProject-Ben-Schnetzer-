using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Ben Schnetzer"
    };
        private static readonly string[] Birthdates = new[]
        {
            "10/27/2000"
        };
        private static readonly string[] CollegePrograms = new[]
        {
            "Digital Media Collaborative"
        };
        private static readonly string[] Years = new[]
        {
            "Senior"
        };

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<NameData> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new NameData
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                ,Birthdate = Birthdates[Random.Shared.Next(Birthdates.Length)]
                ,CollegeProgram = CollegePrograms[Random.Shared.Next(CollegePrograms.Length)]
                ,Year = Years[Random.Shared.Next(Years.Length)]
            })
            .ToArray();
        }
    }
}