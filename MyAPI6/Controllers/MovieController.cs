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
        private readonly ILogger<MovieController>  logger ;
        public MovieController(  IMapper mapper , IOutFit outFit , IMovieRepository movieRepository, ILogger<MovieController> logger)
        {
            this.mapper = mapper;
            this._outFit = outFit;
            this.logger = logger;
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

            try
            {
                for (int i = 0; i < 100010100; i++)
                {
                    logger.LogInformation($"MovieController - isPulic MovieController - isPuMovieController - isPulicMovieController - isPulicMovieController - isPulicMovieController - isPuliclic  {isPulic},isDelete: {isDelete}");
                   
                }
                for (int i = 0; i < 100000110; i++)
                {
                    logger.LogInformation($"MovieController - isPulic MovieController - isPulic MovieController - isPulicMovieController - isPulicMovieController - isPulicMovieController - isPulic  {isPulic},isDelete: {isDelete}");

                }

                for (int i = 0; i < 100011000; i++)
                {
                    logger.LogInformation($"MovieController - MovieController - isPulicMovieController - isPulicMovieController - isPulicisPulic  {isPulic},isDelete: {isDelete}");

                }
                for (int i = 0; i < 100010010; i++)
                {
                    logger.LogInformation($"MovieController - isPulMovieController - isPulicMovieController - isPulicMovieController - isPulicic  {isPulic},isDelete: {isDelete}");

                }
            }
            catch (Exception ex)
            {

                logger.LogError($"Exception Message: {ex.Message},StackTrace: {ex.StackTrace}");
            }

            var lstData = await _movieRepository.GetAll(false,true);
           return lstData;


            
        }
          
    }
}