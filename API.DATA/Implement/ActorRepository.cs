using API.CORE;
using API.CORE.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DATA
{
    public class ActorRepository : IActorRepository
    {
        private readonly MovieContext movieContext;

        public ActorRepository(MovieContext movieContext)
        {
            this.movieContext = movieContext;
        }

        public async Task<List<Actor>> GetAll()
        {
             
            return await this.movieContext.Actors.ToListAsync();
        }
    }
}