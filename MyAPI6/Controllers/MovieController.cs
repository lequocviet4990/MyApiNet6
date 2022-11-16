using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using MyAPI6.Models;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly MovieContext movieContext;

        public MovieController (MovieContext  movieContext)
        {
             this.movieContext = movieContext;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Movie>>>  GetAll()
        {
            return await this.movieContext.Movies.ToListAsync();
        }

        [HttpGet("Get")]
        public async Task<ActionResult<Movie>> Get(long id) //0 
        {

            var b = await this.movieContext.Movies.Where(x => x.Id == id).FirstOrDefaultAsync(); // loi ko
            var c =  await this.movieContext.Movies.FindAsync((int)id);
              c =  await this.movieContext.Movies.FindAsync(int.Parse(id.ToString()));
              c =  await this.movieContext.Movies.FindAsync(int.TryParse(id.ToString(), out  int result));
            var a = await this.movieContext.Movies.Where(x => x.Id == id).FirstAsync();

            return await this.movieContext.Movies.FindAsync(id);

            
        }

        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<Movie>>> Search(string title) //0 
        {

            var b = await this.movieContext.Movies.Where(x => x.Title == title).ToListAsync();
             

            return b;


        }

        [HttpGet("SearchIactionResult")]
        public async Task<IActionResult> SearchIactionResult(string title, string type) //0 
        {
            var result = new object();
            if (type.ToLower() == "movie")
            {

                  result = await this.movieContext.Movies.Where(x => title.Contains(x.Title)).ToListAsync();
               
                  
            }
            else if (type.ToLower() == "actor")
            {
                result = await this.movieContext.Actors.Where(x => title.Contains(x.Name)).ToListAsync();

            }

            return Ok(result); 


        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id) //0 
        {
            var movie = this.movieContext.Movies.Find(id);
            if (movie !=null)
            {
                 this.movieContext.Movies.Remove(movie);    
                await this.movieContext.SaveChangesAsync();
                return Ok();
            }
          
            else
            {
                return NotFound();
            }

        }


    }
}
