using AutoMapper;
using Vidley.Models;

namespace Vidley.Dtos.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MoviesDTO, Movie>();
            CreateMap<Movie, MoviesDTO>();

            CreateMap<GenresDTO, Genre>();
            CreateMap<Genre, GenresDTO>();
        }
    }
}