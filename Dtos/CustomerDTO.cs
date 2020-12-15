using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidley.Models.DataAnnotations;

namespace Vidley.Dtos
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [StringLength(225)]
        [Required(ErrorMessage = "Please, enter your name!")]
        public string Name { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }

        public bool IsSubscribeToNewsletter { get; set; }

        //[Min18ForAMembership]
        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "Please, specify the type of membership.")]
        public int MembershipTypeId { get; set; }
    }
}
