using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            //Look for any movies.
            if (context.Movie.Any())
            {
                return; // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "kweku",
                    ReleaseDate = DateTime.Parse("2025-01-01"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Avengers",
                    ReleaseDate = DateTime.Parse("2026-07-28"),
                    Genre = "Sci-Fi",
                    Rating = "R",
                    Price = 15.99M
                },
                new Movie
                {
                    Title = "Power Book VI",
                    ReleaseDate = DateTime.Parse("2027-04-29"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 27.00M
                },
                new Movie
                {
                    Title = "Breaking Bad",
                    ReleaseDate = DateTime.Parse("2025-09-22"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 15.30M
                },
                new Movie
                {
                    Title = "Madness",
                    ReleaseDate = DateTime.Parse("2028-10-29"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 11.99M
                }
                );
            context.SaveChanges();

            if (context.Movie.Any())
            {
                return; // DB has been seeded.
            }

        }
    }
}


//public class SeedData
//{
//}
