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
        
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime? Birthday { get; set; }

        public int MembershipTypeId { get; set; }
    }
}
