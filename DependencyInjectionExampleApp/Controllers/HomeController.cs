using DependencyInjectionExampleApp.GuidManager.Scoped;
using DependencyInjectionExampleApp.GuidManager.Singleton;
using DependencyInjectionExampleApp.GuidManager.Transient;
using DependencyInjectionExampleApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionExampleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuidManagerSingleton _guidManagerSingleton;
        private readonly IGuidManagerSingleton _guidManagerSingleton2;

        private readonly IGuidManagerScoped _guidManagerScoped;
        private readonly IGuidManagerScoped _guidManagerScoped2;

        private readonly IGuidManagerTransient _guidManagerTransient;
        private readonly IGuidManagerTransient _guidManagerTransient2;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IGuidManagerSingleton guidManager, IGuidManagerScoped guidManagerScoped, IGuidManagerTransient guidManagerTransient, IGuidManagerSingleton guidManagerSingleton2, IGuidManagerScoped guidManagerScoped2, IGuidManagerTransient guidManagerTransient2)
        {
            _logger = logger;
            _guidManagerSingleton = guidManager;
            _guidManagerScoped = guidManagerScoped;
            _guidManagerTransient = guidManagerTransient;
            _guidManagerSingleton2 = guidManagerSingleton2;
            _guidManagerScoped2 = guidManagerScoped2;
            _guidManagerTransient2 = guidManagerTransient2;
        }

        public IActionResult Index()
        {
            var guidSingleton = _guidManagerSingleton.Id.ToString();
            ViewBag.guidSingleton = guidSingleton;

            var guidScoped = _guidManagerScoped.Id.ToString();
            ViewBag.guidScoped = guidScoped;

            var guidTransient = _guidManagerTransient.Id.ToString();
            ViewBag.guidTransient = guidTransient;



            var guidSingleton2 = _guidManagerSingleton2.Id.ToString();
            ViewBag.guidSingleton2 = guidSingleton2;

            var guidScoped2 = _guidManagerScoped2.Id.ToString();
            ViewBag.guidScoped2 = guidScoped2;

            var guidTransient2 = _guidManagerTransient2.Id.ToString();
            ViewBag.guidTransient2 = guidTransient2;


            return View();
        }
        public async Task<JsonResult> GetGuids()
        {
            var guidSingleton = _guidManagerSingleton.Id.ToString();

            var guidScoped = _guidManagerScoped.Id.ToString();

            var guidTransient = _guidManagerTransient.Id.ToString();
            return await Task.Run(()=>Json(new { guidSingleton, guidScoped, guidTransient }));
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
