using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PM_MovieRandomizer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("9792CB5B - 09A3 - 4B49 - 94A1 - 036D494B1BBE"),
                Title = "Pokemon: The First Movie",
                ReleaseDate = DateTime.Parse("06-08-1998"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}