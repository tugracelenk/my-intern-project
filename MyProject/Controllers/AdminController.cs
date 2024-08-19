using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult MovieAdd()
        {
            return View();
        }
    }
}
