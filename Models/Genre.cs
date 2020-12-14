using System.ComponentModel.DataAnnotations;

namespace Vidley.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
