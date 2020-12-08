using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidley.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }
        public bool IsSubscribeToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        public DateTime? Birthday { get; set; }

        public int MembershipTypeId { get; set; }
    }
}
