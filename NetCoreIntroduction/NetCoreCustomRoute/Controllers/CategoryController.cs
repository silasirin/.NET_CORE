using Microsoft.AspNetCore.Mvc;
using NetCoreCustomRoute.Models;

namespace NetCoreCustomRoute.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(Category.categories);
        }
    }
}
