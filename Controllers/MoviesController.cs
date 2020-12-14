using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Vidley.Data;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("movies")]
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        [Route("movies/details/{id?}")]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
                return View(_context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id));
            else
                return BadRequest();
        }

        [Route("movies/byReleaseDate")]
        [Route("movies/byReleaseDate/{year?}/{month?}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            DateTime dateInfo = DateTime.Now;

            if (!year.HasValue)
                year = dateInfo.Year;

            if (!month.HasValue)
                month = dateInfo.Month;

            return Content($"Year: {year}, Month: {month}");
        }

        [Route("movies/random")]
        public ActionResult Random()
        {
            var randomViewModel = new RandomMovieViewModel(
                    new Movie { Name = "Shrek!", Id = 1 },
                    new List<Customer>() { new Customer() { Id = 1, Name = "Sam" }, new Customer() { Id = 2, Name = "Bella" } }
                );

            return View(randomViewModel);
        }

        [Route("movies/new")]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            return View("MovieForm", new MovieFormViewModel() { GenresList = genres });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Route("movies/new")]
        public ActionResult Save(MovieFormViewModel viewModel)
        {
            var movie = new Movie
            {
                Name = viewModel?.Name,
                Genre = GetGenre(viewModel.GenreId),
                DateAdded = DateTime.Now,
                ReleaseDate = (DateTime)viewModel?.ReleaseDate,
                NumberInStock = (int)viewModel?.NumberInStock,
                GenreId = viewModel.GenreId
            };

            if (ModelState.IsValid)
            {
                if (viewModel.Id != null && viewModel.Id == 0)
                    _context.Movies.Add(movie);
                else
                {
                    var movieFromDb = _context.Movies.Single(m => m.Id == viewModel.Id);

                    movieFromDb.Name = movie.Name.Trim();
                    movieFromDb.ReleaseDate = (DateTime) movie.ReleaseDate;
                    movieFromDb.DateAdded = DateTime.Now;
                    movieFromDb.NumberInStock = (int) movie.NumberInStock;
                    movieFromDb.GenreId = movie.GenreId;
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Movies");
            }
            else
            {
                return View("MovieForm", new MovieFormViewModel(movie, _context.Genres.ToList()));
            }
        }

        private Genre GetGenre(int id)
        {
            return _context.Genres.SingleOrDefault(g => g.Id == id);
        }

        [Route("movies/edit")]
        public ActionResult Edit(int? id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie != null)
            {
                var movieViewModel = new MovieFormViewModel
                (
                  movie,
                  _context.Genres.ToList()
                );

                return View("MovieForm", movieViewModel);
            }
            else
            {
                return NotFound();
            }
        }
    }
}