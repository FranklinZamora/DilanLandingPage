using Microsoft.AspNetCore.Mvc;

namespace DilanLanding.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
