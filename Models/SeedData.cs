using FilmArena.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FilmArena.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new FilmArenaContext(serviceProvider.GetRequiredService<DbContextOptions<FilmArenaContext>>()))
            {
                //look for any movies
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "movie 1",
                        ReleaseDate = DateTime.Parse("2012-3-4"),
                        Genre = "Romantic",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "movie 2",
                        ReleaseDate = DateTime.Parse("2013-3-4"),
                        Genre = "Comedy",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "movie 3",
                        ReleaseDate = DateTime.Parse("2016-3-4"),
                        Genre = "Comedy",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "movie 4",
                        ReleaseDate = DateTime.Parse("2014-3-4"),
                        Genre = "Action",
                        Price = 4.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
