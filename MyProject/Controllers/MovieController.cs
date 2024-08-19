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

        public async Task<IActionResult> Index(int districtId)
        {
            // Gelen DistrictId'nin geçerliliğini kontrol et
            var isDistrictValid = await _context.Districts
                    .AnyAsync(d => d.Id == districtId);

            if (!isDistrictValid)
            {
                // Eğer DistrictId geçersizse hata fırlat
                return NotFound("Invalid District ID");
            }

            // Geçerli DistrictId'ye sahip Movie kayıtlarını getir
            var movies = await _context.Movies
                    .Where(m => m.DistrictId == districtId)
                    .Include(m => m.District)
                    .Include(m => m.Category)
                    .ToListAsync();

            return View(movies);
        }
    }
}