using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            return Content("Here, you should see a list with all the movies");
        }

        [Route("movie/byReleaseDate")]
        [Route("movie/byReleaseDate/{year?}/{month?}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            DateTime dateInfo =  DateTime.Now;
            
            if (!year.HasValue)
                year = dateInfo.Year;

            if (!month.HasValue)
                month = dateInfo.Month;

            return Content($"Year: {year}, Month: {month}");
        }

        [Route("movie/random")]
        public IActionResult Random()
        {
            var randomViewModel = new RandomMovieViewModel(
                    new Movie { Name = "Shrek!", Id = 1 },
                    new List<Customer>() { new Customer() { Id = 1, Name = "Sam" }, new Customer() { Id = 2, Name = "Bella" } }
                );
            

            return View(randomViewModel);
        }

        [Route("movie/edit")]
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
