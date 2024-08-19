using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class MovieController : Controller
    {
        private readonly RepositoryContext _context;

        public MovieController(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                .Include(m => m.District)
                .Include(m => m.Category)
                .ToListAsync();

            return View(movies);
        }
    }
}