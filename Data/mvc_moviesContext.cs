using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_movies.Models;

namespace mvc_movies.Data
{
    public class mvc_moviesContext : DbContext
    {
        public mvc_moviesContext (DbContextOptions<mvc_moviesContext> options)
            : base(options)
        {
        }

        public DbSet<mvc_movies.Models.Movie> Movie { get; set; } = default!;
        public DbSet<mvc_movies.Models.Genre> Genre { get; set; } = default!;

    }
}
