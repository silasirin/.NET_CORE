using Microsoft.AspNetCore.Mvc;
using NetCoreTransientScopedSingleton.Models;

namespace NetCoreTransientScopedSingleton.Controllers
{
    public class HomeController : Controller
    {
        //Her istekte yeni bir instance veriyor. Bu nedenle id'ler her defasinda degisiyor. Bunu test ettik.
        //Transient
        private readonly ITransient _transientService1;
        private readonly ITransient _transientService2;

        //Scoped
        private readonly IScoped _scopedService1;
        private readonly IScoped _scopedService2;

        //Singleton
        private readonly ISingleton _singletonService1;
        private readonly ISingleton _singletonService2;

        public HomeController(ITransient transientService1, ITransient transientService2,IScoped scopedService1,IScoped scopedService2, ISingleton singletonService1, ISingleton singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

        }
        public IActionResult Index()
        {
            ViewBag.TransientService1 = _transientService1.GetOperation(); 
            ViewBag.TransientService2 = _transientService2.GetOperation();

            ViewBag.ScopedService1 = _scopedService1.GetOperation();
            ViewBag.ScopedService2 = _scopedService2.GetOperation();

            ViewBag.SingletonService1 = _singletonService1.GetOperation();
            ViewBag.SingletonService2 = _singletonService2.GetOperation();


            return View();
        }
    }
}
