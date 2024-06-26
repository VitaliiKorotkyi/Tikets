﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VKTiketsPG.Data;

namespace VKTiketsPG.Controllers
{
    public class MoviesController : Controller
    {
        readonly private AppDbContext _context;
        public MoviesController(AppDbContext context)
        { 
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies=await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
