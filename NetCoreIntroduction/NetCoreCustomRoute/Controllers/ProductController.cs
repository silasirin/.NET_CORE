using Microsoft.AspNetCore.Mvc;
using NetCoreCustomRoute.Models;
using System.Linq;

namespace NetCoreCustomRoute.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(Product.products);
        }

        public IActionResult GetProducts(int categoryId)
        {
            var products = Product.products.Where(x => x.CategoryID == categoryId).ToList();

            return View(products);
        }
    }
}
