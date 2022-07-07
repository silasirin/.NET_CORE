using Microsoft.AspNetCore.Mvc;

namespace NetCoreIntroduction.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello MVC";
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
