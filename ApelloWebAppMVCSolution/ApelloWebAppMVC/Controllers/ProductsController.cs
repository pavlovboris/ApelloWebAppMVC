using Microsoft.AspNetCore.Mvc;

namespace ApelloWebAppMVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Welcome(string name, int number=13)
        {
            ViewBag.Name = name;
            ViewBag.Number = number;    
            return View();
        }
    }
}
