using API.CORE.Dto;
using API.CORE.Entities;
using AutoMapper;
 

namespace API.CORE.Automapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Movie, MoviesDto>();
            CreateMap<MoviesDto, Movie>();


            CreateMap<ProductModelDto, ProductModel>();
            CreateMap<ProductModel, ProductModelDto>();
        }
    }
}
