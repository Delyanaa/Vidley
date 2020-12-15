using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Vidley.Data;
using Vidley.Models;
using AutoMapper;
using Vidley.Dtos;
using System;
using Microsoft.AspNetCore.Http.Extensions;
using System.Web.Http;
//using System.Web.Http;

namespace Vidley.Controllers.API
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;


        public CustomersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<CustomerDTO> GetCustomers() => _mapper.Map<IEnumerable<CustomerDTO>>(_context.Customers.ToList());

        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public ActionResult GetCustomer(int? id) => (id == null)
            ?  NotFound()
            :  Ok(FindCustomerById((int) id));
        
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public ActionResult CreateCustomer(CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = _mapper.Map<Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Created(new Uri(Request.GetDisplayUrl()), customerDto);
        }

        // PUT: /api/customers/1 
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerFromDb = FindCustomerById(id);
            customerDto.Id = customerFromDb.Id;
            _mapper.Map(customerDto, customerFromDb);
            _context.SaveChanges();

            return Ok(customerFromDb);
        }

        // DELETE: /api/customers/1 
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _context.Customers.Remove(FindCustomerById(id));
            _context.SaveChanges();
        }

        private Customer FindCustomerById(int id)
        {
            Customer customerFromDb = null;
            customerFromDb = _context.Customers.Single(c => c.Id == id);
        

            if (customerFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var customerDto = _mapper.Map<CustomerDTO>(customerFromDb);
            customerDto.MembershipTypeDTO = _mapper.Map<MembershipTypeDTO>(
                _context.MembershipTypes.FirstOrDefault(m => m.Id == customerDto.MembershipTypeId)
                );
            return customerFromDb;
        }
    }
}
