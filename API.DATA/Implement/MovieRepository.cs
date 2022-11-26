using API.CORE;
using API.CORE.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DATA
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext movieContext;

        public MovieRepository(MovieContext movieContext)
        {
            this.movieContext = movieContext;
        }

        public async Task<List<Movie>> GetAll(bool? isDelete, bool? isPublic)
        {
            //var lstdata =new List<Movie>();
            //for (int i = 0; i < 100; i++)
            //{
            //    lstdata.Add(new Movie { Title = $"Tile {i}" });
            //}
            return await this.movieContext.Movies.ToListAsync();
        }
    }
}