using Microsoft.AspNetCore.Mvc;
using NetCoreViewImport.Models;

namespace NetCoreViewImport.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product
            {
                ID = 1,
                ProductName = "Chai"
            };

            return View(product);
        }
    }
}
