using CoreAppFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppFood.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return View(categoryRepository.TList());
        }
    }
}
