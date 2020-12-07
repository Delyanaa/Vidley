using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vidley.Models;

namespace Vidley.Controllers
{
    public class Customers : Controller
    {
        private List<Customer> customerList = new List<Customer>() {
                new Customer{ Id = 1, Name = "John Smith"},
                new Customer{ Id = 2, Name = "Tara Jason"},
                new Customer{ Id = 3, Name = "Lora Petrov"}
        };

        [Route("customers")]
        public ActionResult Index()
        {
            var customers = customerList;

            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
                return View(customerList.Where(c => c.Id == id).FirstOrDefault());
            else
                return BadRequest();
        }
    }
}
