using ApelloWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApelloWebAppMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.Name == "su" && userModel.Password == "cscs")
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailure", userModel);
            }
            
        }
    }
}
