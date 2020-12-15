using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidley.Dtos
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter the name of the film.")]
        [StringLength(256)]
        public string Name { get; set; }

        public GenreDTO Genre { get; set; }

        [Required(ErrorMessage = "Please, enter a valid date.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please, enter a valid date.")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please, enter the quantity.")]
        [Range(1, 20, ErrorMessage = "The quantity must be between 1 and 20.")]
        public int NumberInStock { get; set; }

        [Required(ErrorMessage = "Please, select a genre.")]
        
        public int GenreId { get; set; }
    }
}
