
using API.CORE.Entities;

namespace API.CORE
{
    public interface IMovieRepository
    {
        Task  <List<Movie>> GetAll(bool? isDelete =false , bool? isPublic = true );
    }
}