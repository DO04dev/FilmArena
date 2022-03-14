using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmArena.Models;

namespace FilmArena.Data
{
    public class FilmArenaContext : DbContext
    {
        public FilmArenaContext (DbContextOptions<FilmArenaContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
