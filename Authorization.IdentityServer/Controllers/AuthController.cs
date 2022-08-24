using Authorization.IdentityServer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.IdentityServer.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        [Route("[action]")]
        public IActionResult Login(string returnUrl)
        {
            return View();
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
    }
}
