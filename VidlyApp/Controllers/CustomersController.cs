using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;
using VidlyApp.ViewModels;
using System.Data.Entity;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> CustomersList;
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
            CustomersList = _context.Customers.Include(c => c.MembershipType).ToList();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //[Route("Customers/Details/{id}")]
        public ActionResult Details(int? Id)
        {
            var customer = CustomersList.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        //[Route("Customers")]
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel()
            {
                Customers = this.CustomersList
            };
            return View(viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            CustomerFormViewModel viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }

    }
}