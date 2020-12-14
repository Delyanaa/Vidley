using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
