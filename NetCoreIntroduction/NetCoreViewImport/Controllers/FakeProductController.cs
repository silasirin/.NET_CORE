using Microsoft.AspNetCore.Mvc;
using NetCoreViewImport.Models;

namespace NetCoreViewImport.Controllers
{
    public class FakeProductController : Controller
    {
        [HttpPost]
        public IActionResult Index(Product product)
        {
            return View();
        }
    }
}
