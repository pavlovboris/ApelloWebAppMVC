using ApelloWebAppMVC.Models;
using ApelloWebAppMVC.Services;
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
            SecurityServices security = new SecurityServices();

            if (security.IsValid(userModel))
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
