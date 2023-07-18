using CodeLabNET6.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeLabNET6.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options ) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
