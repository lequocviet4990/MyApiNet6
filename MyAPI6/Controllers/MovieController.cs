using API.CORE;
using API.CORE.Entities;
using AutoMapper;
using ConsoleApp1;
using Microsoft.AspNetCore.Mvc;
 

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
         
        private readonly IMapper mapper;
        private readonly IOutFit _outFit;
        private readonly IMovieRepository  _movieRepository;
        public MovieController(  IMapper mapper , IOutFit outFit , IMovieRepository movieRepository)
        {
            this.mapper = mapper;
            this._outFit = outFit;
            this._movieRepository = movieRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAll(bool? isPulic, bool? isDelete)
        {
            //var now =      this._outFit.GetDateNow();
            //var lstData = await this.movieContext.Movies.ToListAsync();

            //if (isPulic.HasValue)
            //{
            //    lstData = lstData.Where(x => x.IsPublic == true).ToList();
            //}

            var lstData = await _movieRepository.GetAll(false,true);
           return lstData;


            
        }
          
    }
}