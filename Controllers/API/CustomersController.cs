using AutoMapper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Vidley.Data;
using Vidley.Dtos;
using Vidley.Models;

namespace Vidley.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public CustomersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CustomerDTO> GetCustomers() => _mapper.Map<IEnumerable<CustomerDTO>>(_context.Customers.ToList());

        [HttpGet("{id}")]
        public ActionResult GetCustomer(int id) => (id == null)
            ? NotFound()
            : Ok(FindCustomerById((int)id));

        [HttpPost]
        public ActionResult CreateCustomer(CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = _mapper.Map<Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Created(new Uri(Request.GetDisplayUrl()), customerDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, CustomerDTO customerDto)
        {
            if (!ModelState.IsValid || id == 0)
                return BadRequest();

            var customerFromDb = FindCustomerById((int) id);
            customerDto.MembershipType = _mapper.Map<MembershipTypeDTO>(customerFromDb.MembershipType);

            _mapper.Map(customerDto, customerFromDb);
            _context.SaveChanges();

            return Ok(customerFromDb);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _context.Customers.Remove(FindCustomerById(id));
            _context.SaveChanges();
        }

        private Customer FindCustomerById(int id)
        {
            Customer customerFromDb = null;
            customerFromDb = _context.Customers.Single(c => c.Id == id);

            if (customerFromDb == null) throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            customerFromDb.MembershipType = _context.MembershipTypes.FirstOrDefault(m => m.Id == customerFromDb.MembershipTypeId);

            return customerFromDb;
        }
    }
}