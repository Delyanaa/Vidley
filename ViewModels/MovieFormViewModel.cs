using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }

        [Display(Name ="Genre")]
        public IEnumerable<Genre> GenresList { get; set; }
    }
}
