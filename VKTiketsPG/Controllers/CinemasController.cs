using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VKTiketsPG.Data;

namespace VKTiketsPG.Controllers
{
    public class CinemasController : Controller
    {
        readonly private AppDbContext _context; 
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas =await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
