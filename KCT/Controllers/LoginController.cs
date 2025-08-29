using KCT.Interfaces;
using KCT.Services;
using Microsoft.AspNetCore.Mvc;

namespace KCT.Controllers
{
    public class LoginController : Controller
    {
        private readonly IRegistrationService _registrationService;

        public LoginController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var users = await _registrationService.GetAllRegistrationsAsync();

            if (users.Any())
            {
                var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);

                if (user != null)
                {
                    return RedirectToAction("Index"); // success
                }

                // Wrong credentials
                ViewBag.ErrorMessage = "Invalid email or password.";
                return View("Login");
            }

            // No registrations in DB
            ViewBag.ErrorMessage = "No users registered yet. Please contact admin.";
            return View("Login");
        }



    }
}
