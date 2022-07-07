using Microsoft.AspNetCore.Mvc;
using DAL.Models.Entity;
using Web.Utils;

namespace Web.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            var sessionResult = SessionHelper.GetProductSession<Category>(HttpContext.Session, "ornek-oturum");

            return View();
        }

        [HttpPost]
        public IActionResult Index(Category category)
        {
            SessionHelper.SetProductJson(HttpContext.Session, "ornek-oturum", category);
            return View();
        }
    }
}
