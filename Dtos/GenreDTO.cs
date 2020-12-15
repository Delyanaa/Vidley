using System.ComponentModel.DataAnnotations;

namespace Vidley.Dtos
{
    public class GenreDTO
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
