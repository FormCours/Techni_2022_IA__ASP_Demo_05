using Demo_ASP_MVC_05_InjectionDependances.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_05_InjectionDependances.Controllers
{
    public class DemoController : Controller
    {
        private DemoSingletonService _singletonService1;
        private DemoSingletonService _singletonService2;
        private DemoScopedService _scopedService1;
        private DemoScopedService _scopedService2;
        private DemoTransientService _transientService1;
        private DemoTransientService _transientService2;

        public DemoController(DemoSingletonService singletonService1, DemoSingletonService singletonService2, DemoScopedService scopedService1, DemoScopedService scopedService2, DemoTransientService transientService1, DemoTransientService transientService2)
        {
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
        }

        public IActionResult Index()
        {
            ViewData["Singleton1"] = _singletonService1.Count;
            ViewData["Singleton2"] = _singletonService2.Count;
            ViewData["Scoped1"] = _scopedService1.Count;
            ViewData["Scoped2"] = _scopedService2.Count;
            ViewData["Transient1"] = _transientService1.Count;
            ViewData["Transient2"] = _transientService2.Count;

            return View();
        }
    }
}
