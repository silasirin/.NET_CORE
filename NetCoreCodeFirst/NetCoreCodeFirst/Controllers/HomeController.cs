using Microsoft.AspNetCore.Mvc;
using NetCoreCodeFirst.Models.Repository;

namespace NetCoreCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetCategories();
            return View();
        }
    }
}
