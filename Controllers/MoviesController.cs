using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> movieList = new List<Movie> {
                new Movie{ Id = 1, Name = "Shrek!"},
                new Movie{ Id = 2, Name = "Captain America"},
                new Movie{ Id = 3, Name = "As above, so below"},
                new Movie{ Id = 4, Name = "Marley and me"},
                new Movie{ Id = 5, Name = "Gone"}
            };

        [Route("movies")]
        public ActionResult Index()
        {
            var movies = movieList;
            return View(movies);
        }

        [Route("movies/details/{id?}")]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
                return View(movieList.Where(m => m.Id == id).FirstOrDefault());
            else
                return BadRequest();

        }

        [Route("movies/byReleaseDate")]
        [Route("movies/byReleaseDate/{year?}/{month?}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            DateTime dateInfo =  DateTime.Now;
            
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
    }
}
