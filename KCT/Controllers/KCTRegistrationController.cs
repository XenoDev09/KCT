using Microsoft.AspNetCore.Mvc;

namespace KCT.Controllers
{
    public class KCTRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
