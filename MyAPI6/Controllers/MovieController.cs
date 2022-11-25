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
    public class MovieController : ControllerBase
    {
        private readonly MovieContext movieContext;
        private readonly IMapper mapper;
        private readonly IOutFit _outFit;
        private readonly IMovieRepository  _movieRepository;
        public MovieController(MovieContext movieContext, IMapper mapper , IOutFit outFit , IMovieRepository movieRepository)
        {
            this.movieContext = movieContext;
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

            var lstData = _movieRepository.GetAll(false,true);
           return lstData;


            
        }
          
    }
}