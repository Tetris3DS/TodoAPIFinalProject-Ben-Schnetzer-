using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private static readonly string[] Breakfasts = new[]
        {
        "Pancakes"
    };
   private static readonly string[] Lunches = new[]
        {
            "Peanut Butter and Jelly"
        };
   private static readonly string[] Dinners = new[]
        {
            "Tuna Casserole"
        };
   private static readonly string[] Desserts = new[]
        {
            "Cheesecake"
        };
   private static readonly string[] Drinks = new[]
        {
            "Ale-8-One"
        };
        private readonly ILogger<FoodController> _logger;

        public FoodController(ILogger<FoodController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFoodData")]
        public IEnumerable<FoodData> Get()
        {
            return Enumerable.Range(0 , 1).Select(index => new FoodData
            {
                Breakfast = Breakfasts[Random.Shared.Next(Breakfasts.Length)]
                ,Lunch = Lunches[Random.Shared.Next(Lunches.Length)]
                ,Dinner = Dinners[Random.Shared.Next(Dinners.Length)]
                ,Dessert = Desserts[Random.Shared.Next(Desserts.Length)]
                ,Drink = Drinks[Random.Shared.Next(Drinks.Length)]
            })
            .ToArray();
        }
    }
}