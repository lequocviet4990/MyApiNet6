﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI6.Models;
using MyAPI6.Models.Dto;
using MyAPI6.Models.Entities;

namespace MyAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext movieContext;
        private readonly IMapper mapper;

        public MovieController(MovieContext movieContext, IMapper mapper)
        {
            this.movieContext = movieContext;
            this.mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAll()
        {
            return await this.movieContext.Movies.ToListAsync();
        }

        [HttpGet("Get")]
        public async Task<ActionResult<MoviesDto>> Get(int id) //0
        {
            //var b = await this.movieContext.Movies.Where(x => x.Id == id).FirstOrDefaultAsync(); // loi ko
            //var c =  await this.movieContext.Movies.FindAsync((int)id);
            //  c =  await this.movieContext.Movies.FindAsync(int.Parse(id.ToString()));
            //  c =  await this.movieContext.Movies.FindAsync(int.TryParse(id.ToString(), out  int result));
            //var a = await this.movieContext.Movies.Where(x => x.Id == id).FirstAsync();

            //return await this.movieContext.Movies.FindAsync(id);
            var movie = await this.movieContext.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            var movieDto = mapper.Map<MoviesDto>(movie); // clean code ctrl + M + 0
            return movieDto;
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
            if (movie != null)
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

        [HttpPost("Create")]
        public async Task<IActionResult> Create(MoviesDto model) //0
        {
            int id = 0;
            //var entitie =  new Movie();
            //entitie.Id = id;
            //entitie.Title = model.Title;
            //entitie.Genre = model.Genre;


            var entitie = mapper.Map<Movie>(model);


            await this.movieContext.Movies.AddAsync(entitie);
            await this.movieContext.SaveChangesAsync();
            return Ok(entitie.Id); // phải dùng Ok(id) vì xài iactionResult
        }
    }
}