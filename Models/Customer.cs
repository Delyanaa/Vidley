using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidley.Models.DataAnnotations;

namespace Vidley.Models
{
    public class Customer
    {
        public int Id { get; set; }
       
        [StringLength(225)]
        [Required(ErrorMessage ="Please, enter your name!")]
        public string Name { get; set; }
        
        public bool IsSubscribeToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime? Birthday { get; set; }

        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "Please, specify the type of membership.")]
        public int MembershipTypeId { get; set; }
    }
}
