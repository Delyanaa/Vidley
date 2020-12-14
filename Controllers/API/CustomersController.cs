using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net;
using Vidley.Data;
using Vidley.Models;

namespace Vidley.Controllers.API
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {

        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /api/customers 
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<Customer> GetCustomers() => _context.Customers.ToList();

        // GET: /api/customers/1 
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public Customer GetCustomer(int? id) => (id == null) 
            ? throw new HttpResponseException(HttpStatusCode.NotFound) 
            : FindCustomerById((int) id);
        
        // POST: /api/customers 
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
           
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }
        
        // PUT: /api/customers/1 
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public Customer UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid )
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerFromDb = FindCustomerById(id);
            customerFromDb.Name = customer.Name;
            customerFromDb.Birthday = customer.Birthday;
            customerFromDb.IsSubscribeToNewsletter = customer.IsSubscribeToNewsletter;
            customerFromDb.MembershipTypeId = customer.MembershipTypeId;
            _context.SaveChanges();

            return customerFromDb;
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
            var customerFromDb = _context.Customers.Single(c => c.Id == id);
            if (customerFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customerFromDb;
        }
    }
}
