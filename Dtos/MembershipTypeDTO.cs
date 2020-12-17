using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidley.Dtos
{
    public class MembershipTypeDTO
    {
        public int Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        
        //public short SignUpFee { get; set; }
        
        //public byte DiscountRate { get; set; }
        
        //public byte DurationInMonths { get; set; }

        //public static readonly int Unknown = 1;
        //public static readonly int PayAsYouGo = 1;
    }
}
