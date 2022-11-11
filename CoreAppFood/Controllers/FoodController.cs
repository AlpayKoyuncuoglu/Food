using CoreAppFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppFood.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList());
        }
    }
}
