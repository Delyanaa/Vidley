using AutoMapper;
using Vidley.Models;

namespace Vidley.Dtos.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDTO, Movie>();
            CreateMap<Movie, MovieDTO>();

            CreateMap<GenreDTO, Genre>();
            CreateMap<Genre, GenreDTO>();
        }
    }
}