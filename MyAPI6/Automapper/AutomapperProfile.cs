using API.CORE.Entities;
using AutoMapper;
using MyAPI6.Models.Dto;
using MyAPI6.Models.Entities;

namespace MyAPI6.Automapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Movie, MoviesDto>();
            CreateMap<MoviesDto, Movie>();
        }
    }
}
