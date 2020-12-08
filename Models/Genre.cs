using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidley.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public String Name { get; set; }
    }
}
