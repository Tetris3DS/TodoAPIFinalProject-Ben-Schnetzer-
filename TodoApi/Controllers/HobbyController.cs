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
        private static readonly string[] Hobbys2 = new[]
        {
        "Running"
    };
        private static readonly string[] Hobbys3 = new[]
        {
        "Game Development"
    };
        private static readonly string[] Hobbys4 = new[]
        {
        "Boating"
    };
        private static readonly string[] Hobbys5 = new[]
        {
        "Hanging out with Friends"
    };

        private readonly ILogger<HobbyController> _logger;

        public HobbyController(ILogger<HobbyController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHobbyData")]
        public IEnumerable<HobbyData> Get()
        {
            return Enumerable.Range(0, 1).Select(index => new HobbyData
            {
                Hobby = Hobbys[Random.Shared.Next(Hobbys.Length)]
                ,Hobby2 = Hobbys2[Random.Shared.Next(Hobbys2.Length)]
                ,Hobby3 = Hobbys3[Random.Shared.Next(Hobbys3.Length)]
                ,Hobby4 = Hobbys4[Random.Shared.Next(Hobbys4.Length)]
                ,Hobby5 = Hobbys5[Random.Shared.Next(Hobbys5.Length)]
            })
            .ToArray();
        }
    }
}