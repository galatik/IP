using Microsoft.AspNetCore.Mvc;

namespace IP.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View("_Register");
        }

        public IActionResult Login()
        {
            return View("_Login");
        }
    }
}