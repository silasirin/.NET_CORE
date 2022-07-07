using Microsoft.AspNetCore.Mvc;

namespace NetCoreCustomRoute.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
