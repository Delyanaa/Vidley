using System;
using System.ComponentModel.DataAnnotations;

namespace Vidley.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DiscountRate { get; set; }
        public byte DurationInMonths { get; set; }
    }
}