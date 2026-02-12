using Microsoft.EntityFrameworkCore;

namespace Mission6Assignment.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Collection> Collections { get; set; } = null!;
    }
}