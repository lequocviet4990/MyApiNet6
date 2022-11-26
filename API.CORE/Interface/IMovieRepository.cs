
using API.CORE.Entities;

namespace API.CORE
{
    public interface IMovieRepository
    {
        Task  <List<Movie>> GetAll(bool? isDelete, bool? isPublic);
    }
}