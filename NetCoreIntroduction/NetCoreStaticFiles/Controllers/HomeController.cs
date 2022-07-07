using Microsoft.AspNetCore.Mvc;

namespace NetCoreStaticFiles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
