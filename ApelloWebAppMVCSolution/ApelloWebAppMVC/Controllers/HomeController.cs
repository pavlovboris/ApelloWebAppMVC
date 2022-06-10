using ApelloWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApelloWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            for(int test=0;test<5;test++)
            {
                ViewBag.Message3  = test.ToString();
            }
            
             
            return View();
        }
            

        public IActionResult Privacy()
        {
            ViewBag.Message1 = "testing msg 1";
            ViewBag.Message2 = "teating msg 2";
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}