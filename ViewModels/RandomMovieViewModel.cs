using System.Collections.Generic;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

        public RandomMovieViewModel(Movie movie, List<Customer> list)
        {
            Movie = movie;
            Customers = list;
        }
    }
}
