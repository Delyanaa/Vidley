using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please, enter the name of the film.")]
        [StringLength(256)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter a valid date.")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please, enter the quantity.")]
        [Display(Name = "Number In Stock")]
        [Range(1, 20, ErrorMessage = "The quantity must be between 1 and 20.")]
        public int? NumberInStock { get; set; }

        [Required(ErrorMessage = "Please, select a genre.")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Genre")]
        public IEnumerable<Genre> GenresList { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel(Movie movie, IEnumerable<Genre> genresList)
        {
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            GenresList = genresList;
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
    }
}
