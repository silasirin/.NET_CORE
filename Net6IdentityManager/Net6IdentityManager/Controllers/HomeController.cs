using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Net6IdentityManager.Models;
using System.Diagnostics;

namespace Net6IdentityManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityRole> _userManager;

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager,UserManager<IdentityRole> userManager)
        {

            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}