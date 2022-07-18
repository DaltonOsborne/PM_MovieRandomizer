using Microsoft.EntityFrameworkCore;
using PM_MovieRandomizer.Data;
using PM_MovieRandomizer.Models;

namespace PM_MovieRandomizer.Repositories
{
    public static class MoviesRepository
    {
        public static async Task<Movie> GetRandomMovieAsync(ApplicationDbContext db) {
            var movie = await db.Movies.ToListAsync();

            var movieCount = movie.Count();

            var rand = new Random();
            var randNum = rand.Next(0, movieCount);

            var randMovie = movie[randNum];

            return randMovie;
        }
    }
}
