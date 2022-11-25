using API.CORE.Entities;
using API.CORE.Interface;
using AutoMapper;
using ConsoleApp1;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI6.Models;
using MyAPI6.Models.Dto;
using MyAPI6.Models.Entities;
using System;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly MovieContext movieContext;
        private readonly IMapper mapper;
        private readonly IOutFit _outFit;
        private readonly IMovieRepository _movieRepository;

        public ScheduleController(MovieContext movieContext, IMapper mapper , IOutFit outFit , IMovieRepository movieRepository)
        {
            this.movieContext = movieContext;
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
            var lstMovie = _movieRepository.GetAll(false,true);
            return lstMovie;
            
        }
         
    }
}