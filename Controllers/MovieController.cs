using CodeLabNET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeLabNET6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Movie movie)
        {
            movie.Id = Guid.NewGuid();
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id });
        }
        [HttpGet]
        public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 10 )
        {
            return movies.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(Guid id)
        {
            var movie = movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null) return NotFound();
            return Ok(movie);
        }
    }
}
