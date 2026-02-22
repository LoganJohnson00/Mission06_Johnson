using Microsoft.EntityFrameworkCore;

namespace Mission6Assignment.Models
{
    public class MovieContext : DbContext // Liaison
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) // Constructor that runs once
        {
        } 

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
    }
}