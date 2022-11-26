using API.CORE;
using API.CORE.Entities;
using AutoMapper;
using ConsoleApp1;
using Microsoft.AspNetCore.Mvc;
 
namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
    
        private readonly IMapper mapper;
        private readonly IOutFit _outFit;
        private readonly IMovieRepository _movieRepository;

        public ScheduleController(  IMapper mapper , IOutFit outFit , IMovieRepository movieRepository)
        {
   
            this.mapper = mapper;
            this._outFit = outFit;
            this._movieRepository = movieRepository;

        }

        [HttpGet("GetMovieToday")]
        public async Task<ActionResult<List<Movie>>> GetMovieToday(bool ispublic, bool isDelte)
        {
            ////danh sách phim 
            //var lstMovie=   await this.movieContext.Movies.ToListAsync();
            //  //fitter startdate

            //  if (ispublic)
            //  {
            //      lstMovie = lstMovie.Where(x => x.IsPublic == true).ToList();
            //  }
            var lstMovie = await _movieRepository.GetAll(false,true);
            return lstMovie;
            
        }
         
    }
}