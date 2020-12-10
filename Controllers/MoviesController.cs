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

        [Route("movies/edit")]
        public ActionResult Edit(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"?pageIndex={pageIndex}&sortBy={sortBy}");
        }


        [Route("movies/new")]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            return View("MovieForm", new MovieFormViewModel() { Genres = genres});
        }

        [HttpPost]
        [Route("movies/new")]
        public ActionResult Save(MovieFormViewModel viewModel)
        {
            if (viewModel.Movie.Id == 0)
            {
                _context.Movies.Add(viewModel.Movie);
            }
            else
            {

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}