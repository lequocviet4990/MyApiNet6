

using API.CORE.Entities;

namespace API.CORE.Interface
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAll(bool? isDelete, bool? isPublic)
        {
            var lstdata =new List<Movie>();
            for (int i = 0; i < 100; i++)
            {
                lstdata.Add(new Movie { Title = $"Tile {i}" });
            }
            return lstdata;
        }
    }
}