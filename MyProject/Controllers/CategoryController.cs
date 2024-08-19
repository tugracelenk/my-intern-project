using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
