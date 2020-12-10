using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vidley.Data;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("customers")]
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

                if (customer == null)
                    return BadRequest();
                else
                    return View(customer);
            }
            else
                return BadRequest();
        }

        [Route("customers/new")]
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            return View("CustomerForm", new CustomerFormViewModel() { MembershipTypesList = membershipTypes });
        }

        [HttpPost]
        [Route("customers/new")]
        public ActionResult Create(CustomerFormViewModel model)
        {
            if (model != null)
            {
                _context.Customers.Add(model.Customer);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Customers");
        }

        [Route("customers/edit")]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            var viewModel = new CustomerFormViewModel 
            { 
                Customer = customer, 
                MembershipTypesList = _context.MembershipTypes.ToList() 
            };

            return View("CustomerForm", viewModel);
        }
    }
}
