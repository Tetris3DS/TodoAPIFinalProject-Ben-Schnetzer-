using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController : ControllerBase
    {
        private static readonly string[] Shirts = new[]
        {
        "Skyline-Chili T-Shirt"
    };
   private static readonly string[] PantsPair = new[]
        {
            "Black Sweatpants"
        };
   private static readonly string[] ShoePair = new[]
        {
            "Orange Gym Shoes"
        };
   private static readonly string[] Hats = new[]
        {
            "Ski Helmet"
        };
   private static readonly string[] Others = new[]
        {
            "Maroon Sweatshirt"
        };
        private readonly ILogger<ClothesController> _logger;

        public ClothesController(ILogger<ClothesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetClothesData")]
        public IEnumerable<ClothesData> Get()
        {
            return Enumerable.Range(0, 1).Select(index => new ClothesData
            {
                Shirt = Shirts[Random.Shared.Next(Shirts.Length)]
                ,Pants = PantsPair[Random.Shared.Next(PantsPair.Length)]
                ,Shoes = ShoePair[Random.Shared.Next(ShoePair.Length)]
                ,Hat = Hats[Random.Shared.Next(Hats.Length)]
                ,Other = Others[Random.Shared.Next(Others.Length)]
            })
            .ToArray();
        }
    }
}