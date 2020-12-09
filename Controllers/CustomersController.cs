﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vidley.Data;
using Vidley.Models;

namespace Vidley.Controllers
{
    public class Customers : Controller
    {
        private ApplicationDbContext _context;

        public Customers(ApplicationDbContext context)
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
                var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);

                if (customer == null)
                    return BadRequest();
                else
                    return View(customer);
            }
            else 
                return BadRequest();
        }

        [Route("customers/newCustomer")]
        public ActionResult NewCustomer()
        {
            return View();
        }
    }
}
