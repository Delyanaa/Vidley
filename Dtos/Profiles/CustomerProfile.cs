using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidley.Models;

namespace Vidley.Dtos.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile(string profileName) : base(profileName)
        {
            CreateMap<Customer, CustomerDTO>().ForMember(c=> c.Id, opt => opt.Ignore());
            CreateMap<CustomerDTO, Customer>();
            CreateMap<MembershipType, MembershipTypeDTO>();
            CreateMap<MembershipTypeDTO, MembershipType>();
        }
        
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<MembershipType, MembershipTypeDTO>();
            CreateMap<MembershipTypeDTO, MembershipType>();
        }
    }
}
