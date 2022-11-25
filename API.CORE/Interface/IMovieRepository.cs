
using API.CORE.Entities;

namespace API.CORE.Interface
{
    public interface IMovieRepository
    {
        List<Movie> GetAll(bool? isDelete, bool? isPublic);
    }
}