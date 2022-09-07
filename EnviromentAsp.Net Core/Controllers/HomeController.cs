using EnviromentAsp.Net_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EnviromentAsp.Net_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //www.alishub.com (Development oder Production)
        //www.alpha.alishub.com (Alpha-Umgebung)
        public IActionResult Index()
        {
            //throw new Exception("Es gibt Fehler...");
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