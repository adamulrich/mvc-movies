using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using mvc_movies.Data;
using System;
using System.Linq;

namespace mvc_movies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new mvc_moviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<mvc_moviesContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(

                 new Movie
                 {
                     Title = "17 Miracles",
                     ReleaseDate = DateTime.Parse("2011-06-03"),
                     Genre = "History",
                     Price = 23.51M,
                     Rating = "PG",
                     imageURL = "https://image.tmdb.org/t/p/w500/Ye7lE3i0voRICAlDaQqa9vB747.jpg"
                 },
                new Movie
                {
                    Title = "Mobsters and Mormons",
                    ReleaseDate = DateTime.Parse("2005-09-09"),
                    Genre = "Comedy",
                    Price = 24.27M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/9y59QWol7ctwIKBZuMe1uxMDah1.jpg"
                },
                new Movie
                {
                    Title = "Legacy",
                    ReleaseDate = DateTime.Parse("1993-07-03"),
                    Genre = "Drama",
                    Price = 23.01M,
                    Rating = "",
                    imageURL = "https://image.tmdb.org/t/p/w500/uPuyyjYS2fv3nZuaMMdCq251gzt.jpg"
                },
                new Movie
                {
                    Title = "The Home Teachers",
                    ReleaseDate = DateTime.Parse("2004-01-09"),
                    Genre = "Comedy",
                    Price = 17.99M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/iVucUTGN3TXp9VvddLxz846pEiA.jpg"
                },
                new Movie
                {
                    Title = "The Mountain of the Lord",
                    ReleaseDate = DateTime.Parse("1993-03-01"),
                    Genre = "History",
                    Price = 8.38M,
                    Rating = "",
                    imageURL = "https://image.tmdb.org/t/p/w500/2Lbeld2zqewPBpO6l2xGRMciHG5.jpg"
                },
                new Movie
                {
                    Title = "Church Ball",
                    ReleaseDate = DateTime.Parse("2006-03-17"),
                    Genre = "Comedy",
                    Price = 23.15M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/iG2mVQlZciA1p7xcl4x53dZ9yw9.jpg"
                },
                new Movie
                {
                    Title = "The Book of Mormon Movie, Volume 1: The Journey",
                    ReleaseDate = DateTime.Parse("2003-09-12"),
                    Genre = "Adventure",
                    Price = 14.54M,
                    Rating = "PG-13",
                    imageURL = "https://image.tmdb.org/t/p/w500/ov4rsTmjJ28jUnSRRYwhIGWUWUn.jpg"
                },
                new Movie
                {
                    Title = "How Rare a Possession: The Book of Mormon",
                    ReleaseDate = DateTime.Parse("1987-11-08"),
                    Genre = "Drama",
                    Price = 11.22M,
                    Rating = "NR",
                    imageURL = "https://image.tmdb.org/t/p/w500/fvOmKq1amdIZC3s4bWuyUCNXQzd.jpg"
                },
                new Movie
                {
                    Title = "The Singles Ward",
                    ReleaseDate = DateTime.Parse("2002-01-30"),
                    Genre = "Comedy",
                    Price = 10.98M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/A1l7mSbptwFdutUbOq4zzhH4goa.jpg"
                },
                new Movie
                {
                    Title = "The Singles 2nd Ward",
                    ReleaseDate = DateTime.Parse("2007-12-11"),
                    Genre = "Comedy",
                    Price = 18.2M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/ujCtMl8ncRTBHCis4V92jhYyhUW.jpg"
                },
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-01-24"),
                    Genre = "Comedy",
                    Price = 21.19M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/OQ3X7k13koP833iZx1PRIPngZ8.jpg"
                },
                new Movie
                {
                    Title = "Saints and Soldiers",
                    ReleaseDate = DateTime.Parse("2003-09-11"),
                    Genre = "War",
                    Price = 18.14M,
                    Rating = "12",
                    imageURL = "https://image.tmdb.org/t/p/w500/A4LgmMTiRpkEzC6pxRcxE28IDov.jpg"
                },
                new Movie
                {
                    Title = "Midway to Heaven",
                    ReleaseDate = DateTime.Parse("2011-02-04"),
                    Genre = "Romance",
                    Price = 21.14M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/zHI3xAxLlq7BqHdqD9euyfSwnrf.jpg"
                },
                new Movie
                {
                    Title = "The Best Two Years",
                    ReleaseDate = DateTime.Parse("2004-02-20"),
                    Genre = "Comedy",
                    Price = 8.6M,
                    Rating = "PG",
                    imageURL = "https://image.tmdb.org/t/p/w500/regPVSdn7PUJmY7vWc6n4Qjsb4q.jpg"
                },
                new Movie
                {
                    Title = "Johnny Lingo",
                    ReleaseDate = DateTime.Parse("1969-01-01"),
                    Genre = "Drama",
                    Price = 20.22M,
                    Rating = "NR",
                    imageURL = "https://image.tmdb.org/t/p/w500/29wBh1U7KamvPMOCkBZpQo21Us3.jpg"
                },
                new Movie
                {
                    Title = "The Australian Pink Floyd Show",
                    ReleaseDate = DateTime.Parse("2004-10-27"),
                    Genre = "Music",
                    Price = 15.47M,
                    Rating = "",
                    imageURL = "https://image.tmdb.org/t/p/w500/2eSUH0V5q2jzkakRIP9OwlYr5PR.jpg"
                }
        );
            context.SaveChanges();
        }
    }
}