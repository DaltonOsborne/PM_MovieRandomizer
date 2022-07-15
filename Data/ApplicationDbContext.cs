using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PM_MovieRandomizer.Models;

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
                Id = Guid.Parse("F11DDDA7-BB09-4D47-8DA6-26F2065F15C8"),
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