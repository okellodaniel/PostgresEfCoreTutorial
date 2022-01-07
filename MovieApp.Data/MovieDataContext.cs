using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class MovieDataContext : DbContext
    {
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Actors> Actors {get;set;}
        
        public MovieDataContext(DbContextOptions<MovieDataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
    }
}