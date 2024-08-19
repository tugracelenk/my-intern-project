using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class DistrictController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
