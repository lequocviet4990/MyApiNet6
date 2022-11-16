using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI6.Models;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly MovieContext movieContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movieContext"></param>
        public MovieController (MovieContext  movieContext)
        {
             this.movieContext = movieContext;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Movie>>>  Get()
        {
            return await this.movieContext.Movies.ToListAsync();
        }
}
}
