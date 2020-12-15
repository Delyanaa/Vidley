using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Vidley.Data;
using Vidley.Dtos;
using Vidley.Models;

namespace Vidley.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public ApplicationDbContext _context;
        public IMapper _mapper;

        public MoviesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<MovieDTO> GetMovies() => _mapper.Map<IEnumerable<MovieDTO>>(_context.Movies.Include(m => m.Genre).ToList());

        [HttpGet("{id?}")]
        public ActionResult GetMovie(int? id) => (!id.HasValue) ? BadRequest() : Ok(_mapper.Map<MovieDTO>(FindMovieById(id)));


        [HttpPost]
        public ActionResult CreateMovie(MovieDTO movieDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            _context.Movies.Add(_mapper.Map<Movie>(movieDTO));
            _context.SaveChanges();

            return Created(new Uri(Request.GetDisplayUrl()), movieDTO);
        }

        [HttpPut("{id?}")]
        public ActionResult UpdateMovie(int? id, MovieDTO movieDTO)
        {
            if (!ModelState.IsValid || id == 0 || !id.HasValue) return BadRequest();

            var movieFromDb = FindMovieById(id);
            movieDTO.Genre = _mapper.Map<GenreDTO>(movieFromDb.Genre);
            _mapper.Map(movieDTO, movieFromDb);
            _context.SaveChanges();

            return Ok(movieDTO);
        }

        [HttpDelete("{id?}")]
        public ActionResult DeleteMovie(int? id)
        {
            if (!id.HasValue) return BadRequest();
            _context.Movies.Remove(FindMovieById(id));
            _context.SaveChanges();

            return Ok();            
        }

        private Movie FindMovieById(int? id)
        {
            Movie movieFromDB = _context.Movies.Single(m => m.Id == id);
            if (movieFromDB == null) throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);

            movieFromDB.Genre = _context.Genres.FirstOrDefault(g => g.Id == movieFromDB.GenreId);

            return movieFromDB;
        }
    }
}
