using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmArena.Data;
using FilmArena.Models;

namespace FilmArena.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FilmArenaContext _context;

        public IndexModel(FilmArenaContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}