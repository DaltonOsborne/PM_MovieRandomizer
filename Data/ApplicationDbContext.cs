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

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("787d31a1-9ef9-4878-a5a7-05bcbead08d4"),
                Title = "Diancie and the Coccoon of Destruction",
                ReleaseDate = DateTime.Parse("6/19/2014"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("9b81b94a-b349-416a-bf6a-1e0ee522af0b"),
                Title = "Kyruem vs.the Sword of Justice",
                ReleaseDate = DateTime.Parse("6/14/2012"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("05fcfd45-9640-44e5-a9c8-474771bb0f0d"),
                Title = "Mewtwo Strikes Back:Evolution",
                ReleaseDate = DateTime.Parse("6/12/2019 "),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("0b563a12-95fe-4b3b-b064-2b313d9e8fad"),
                Title = "Pokemon:The Movie 2000",
                ReleaseDate = DateTime.Parse("6/17/1999 "),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("0f01cf4c-ada8-47bf-851c-54511fcc9452"),
                Title = "Genesect and the Legend Awakened",
                ReleaseDate = DateTime.Parse("6/13/2013"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("78b7ee83-de99-4c18-bdcd-e51509fba783"),
                Title = "Jirachi—Wish Maker",
                ReleaseDate = DateTime.Parse("6/19/2003"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("f92ee42d-59c3-49a5-a0ca-54ba1e15fe80"),
                Title = "Pokémon 4Ever: Celebi - Voice of the Forest",
                ReleaseDate = DateTime.Parse("6/7/2001"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("c4d62c29-2e5c-44ba-abc2-54ca990f1f89"),
                Title = "I Choose You!",
                ReleaseDate = DateTime.Parse("6/16/2017"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("6da8557d-a8ee-4007-8f3f-589e11774875"),
                Title = "Pokémon 3: The Movie - Spell of the Unown",
                ReleaseDate = DateTime.Parse("6/8/2000"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("a68b0e49-d999-4a65-8b61-75351fbbb140"),
                Title = "The Rise of Darkrai",
                ReleaseDate = DateTime.Parse("6/24/2007 "),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("e8a299e3-c2e2-43bd-bed6-67535548fcca"),
                Title = "The Power of Us",
                ReleaseDate = DateTime.Parse("6/13/2018"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("3b4ea11f-d809-4171-85c9-69689bd4590c"),
                Title = "Arceus and the Jewel of Life",
                ReleaseDate = DateTime.Parse("6/18/2009"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("ce40dcbe-9c39-4705-8d47-731597dfd50e"),
                Title = "Zoroark--Master of Illusions",
                ReleaseDate = DateTime.Parse("6/10/2010"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("faf5bb2f-33c6-495c-b179-76a72f119781"),
                Title = "Pokémon Heroes: Latios and Latias",
                ReleaseDate = DateTime.Parse("6/13/2002"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("984a54c7-a77e-4170-abbe-93c0f10a4473"),
                Title = "Hoopa and the Clash of Ages",
                ReleaseDate = DateTime.Parse("6/18/2015"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("e5464945-4a65-4fec-8b66-a945497238df"),
                Title = "Secrets of the Jungle",
                ReleaseDate = DateTime.Parse("12/25/2020"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("e48c1456-5e27-4304-9bae-b3e18045811d"),
                Title = "Pokemon Ranger and the Temple of the Sea",
                ReleaseDate = DateTime.Parse("6/15/2006 "),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("9cf5db30-ee2b-449c-9932-b4a1f416416c"),
                Title = "Destiny Deoxys",
                ReleaseDate = DateTime.Parse("6/22/2004 "),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("ab8c3688-d543-4da2-b99c-c2c8d62f3507"),
                Title = "Giratina and the Sky Warrior",
                ReleaseDate = DateTime.Parse("6/19/2008"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("e7e25a3f-a394-4ab4-90db-dc9842bc8c47"),
                Title = "Lucario and the Mystery of Mew",
                ReleaseDate = DateTime.Parse("6/16/2005"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("fe92db7f-1a35-4bca-97ee-de59b25b5111"),
                Title = "Black--Victini and Reshiram",
                ReleaseDate = DateTime.Parse("6/16/2011"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("ec4a1ebe-a63f-4f53-afac-f40cef1d6f5b"),
                Title = "Volcanion and the Mechanical Marvel",
                ReleaseDate = DateTime.Parse("6/16/2016"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = Guid.Parse("e9a4eba3-da09-40b9-8a2e-f7558a240d23"),
                Title = "White--Victini and Zekrom",
                ReleaseDate = DateTime.Parse("6/16/2011"),
                OpeningWeekendSales = 345345345,
                TotalSales = 34534534,
                Rating = Rating.E
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}