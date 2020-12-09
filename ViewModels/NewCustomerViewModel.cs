using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }

        public IEnumerable<MembershipType> MembershipTypesList { get; set; }

        public NewCustomerViewModel(Customer customer, IEnumerable<MembershipType> membershipTypesList)
        {
            Customer = customer;
            MembershipTypesList = membershipTypesList;
        }
    }
}
