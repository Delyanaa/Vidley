using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vidley.Controllers.API;
using Vidley.Data;
using Vidley.Dtos;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public CustomerController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        /// <summary>
        /// Shows list of customers
        /// </summary>
        /// <returns></returns>
        [Route("[controller]")]
        public ActionResult Index()
        {
            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View();
        }

        [Route("[controller]/details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var customer = _context.Customers
                    .Include(c => c.MembershipType)
                    .SingleOrDefault(c => c.Id == id);

                if (customer == null)
                    return BadRequest();
                else
                    return View(customer);
            }
            else
                return BadRequest();
        }

        /// <summary>
        /// Renders empty customer form
        /// </summary>
        /// <returns></returns>
        [Route("[controller]/new")]
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            return View("CustomerForm", new CustomerFormViewModel() { MembershipTypesList = membershipTypes, Customer = new Customer() });
        }

        /// <summary>
        /// Creates a new customer or saves new details for an existing one
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Route("[controller]/new")]
        public ActionResult Save(CustomerFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Customer.Id == 0)
                {
                    _context.Customers.Add(model.Customer);
                }
                else
                {
                    var customerDTO = _mapper.Map<CustomerDTO>(model.Customer);
                    var customerFromDb = _context.Customers.Single(c => c.Id == customerDTO.Id);

                    _mapper.Map<CustomerDTO, Customer>(customerDTO, customerFromDb);
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("CustomerForm",
                new CustomerFormViewModel{Customer = model.Customer, MembershipTypesList = _context.MembershipTypes.ToList()});
        }

        [Route("[controller]/edit")]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypesList = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}
