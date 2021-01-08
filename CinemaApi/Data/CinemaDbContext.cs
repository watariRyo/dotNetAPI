using System;
using CinemaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaApi.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies;
    }
}
