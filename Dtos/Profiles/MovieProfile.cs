using AutoMapper;
using Vidley.Models;

namespace Vidley.Dtos.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDTO, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
            CreateMap<Movie, MovieDTO>();

            CreateMap<GenreDTO, Genre>();
            CreateMap<Genre, GenreDTO>();
        }
    }
}