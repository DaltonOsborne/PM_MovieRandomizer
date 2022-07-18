using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PM_MovieRandomizer.Data;
using PM_MovieRandomizer.Models;
using PM_MovieRandomizer.Repositories;

namespace PM_MovieRandomizer.Controllers
{

    public class MoviesQuery { 
        public string Title { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MoviesAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("random")]
        public async Task<ActionResult<Movie>> GetRandomMovie()
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }


            var randMovie = await MoviesRepository.GetRandomMovieAsync(_context);


            if (randMovie == null)
            {
                return NotFound();
            }

            return randMovie;

        }

            // GET: api/MoviesAPI
            [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies(string? title = null, Rating? rating = null)
        {
          if (_context.Movies == null)
          {
              return NotFound();
          }

          if (title == null && rating != null)
            {
                return await GetMoviesByTitle(title, rating);
            }

            return await _context.Movies.ToListAsync();
        }

        
        public async Task<ActionResult<IEnumerable<Movie>>> GetMoviesByTitle(string? title, Rating? rating)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            return await _context.Movies.Where(m => m.Title == title && m.Rating == rating). ToListAsync();
        }

        // GET: api/MoviesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(Guid id)
        {
          if (_context.Movies == null)
          {
              return NotFound();
          }
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // PUT: api/MoviesAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(Guid id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MoviesAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
          if (_context.Movies == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Movies'  is null.");
          }
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/MoviesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(Guid id)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(Guid id)
        {
            return (_context.Movies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
