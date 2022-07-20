using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View("~/Views/Pages/Auth/Register.cshtml");
        }
    }
}
