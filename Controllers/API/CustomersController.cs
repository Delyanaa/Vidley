using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net;
using Vidley.Data;
using Vidley.Models;
using AutoMapper;
using Vidley.Dtos;

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

        // GET: /api/customers 
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<CustomerDTO> GetCustomers() => _mapper.Map<IEnumerable<CustomerDTO>>(_context.Customers.ToList());

        // GET: /api/customers/1 
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public Customer GetCustomer(int? id) => (id == null) 
            ? throw new HttpResponseException(HttpStatusCode.NotFound) 
            : FindCustomerById((int) id);
        
        // POST: /api/customers 
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public CustomerDTO CreateCustomer(CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = _mapper.Map<Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customerDto;
        }
        
        // PUT: /api/customers/1 
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public CustomerDTO UpdateCustomer(int id, CustomerDTO customerDto)
        {
            if (!ModelState.IsValid )
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerFromDb = FindCustomerById(id);
            customerFromDb.Name = customerDto.Name;
            customerFromDb.Birthday = customerDto.Birthday;
            customerFromDb.IsSubscribeToNewsletter = customerDto.IsSubscribeToNewsletter;
            customerFromDb.MembershipTypeId = customerDto.MembershipTypeId;

            _context.SaveChanges();

            return _mapper.Map<CustomerDTO>(customerFromDb);
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
            try
            {
                 customerFromDb = _context.Customers.Single(c => c.Id == id);
            }
            catch (System.InvalidOperationException)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            
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
