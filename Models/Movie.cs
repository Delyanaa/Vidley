using System;
using System.ComponentModel.DataAnnotations;

namespace Vidley.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter the name of the film.")]
        [StringLength(256)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please, enter a valid date.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please, enter a valid date.")]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please, enter the quantity.")]
        [Display(Name = "Number In Stock")]
        [Range(1,20, ErrorMessage ="The quantity must be between 1 and 20.")]
        public int NumberInStock { get; set; }

        [Required(ErrorMessage = "Please, select a genre.")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}