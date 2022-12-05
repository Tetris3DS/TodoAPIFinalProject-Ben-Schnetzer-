using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : ControllerBase
    {
        private static readonly string[] Hobbys = new[]
        {
        "Skiing"
    };

        private readonly ILogger<HobbyController> _logger;

        public HobbyController(ILogger<HobbyController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHobbyData")]
        public IEnumerable<HobbyData> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new HobbyData
            {
                Hobby = Hobbys[Random.Shared.Next(Hobbys.Length)]
            })
            .ToArray();
        }
    }
}