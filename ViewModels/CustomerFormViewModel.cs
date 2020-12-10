using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }

        public IEnumerable<MembershipType> MembershipTypesList { get; set; }
    }
}
