using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidya.Models;
using Vidya.ViewModels;

namespace Vidya.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        //public ActionResult Index()
        //{
        //    var customers = new List<Customer>
        //    {
        //        new Customer { Id = 1, Name = "John Smith" },
        //        new Customer { Id = 2, Name = "Mary Williams" }
        //    };

        //    var viewModel = new CustomerViewModel
        //    {
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //}
        //[Route("customers/details/{id}/{name}")]
        //public ActionResult Details(int id, string name)
        //{
        //    var customer = new Customer
        //    {
        //        Id = id,
        //        Name = name
        //    };

        //    var viewModel = new CustomerViewModel
        //    {
        //        Customer = customer
        //    };
        //    return View(viewModel);
        //}


    }
}