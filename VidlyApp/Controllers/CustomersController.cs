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

        [Route("Customers/{id:int}")]
        public ActionResult Index(int? Id)
        {
            var customer = CustomersList.SingleOrDefault(c => c.Id == Id);

            return View(customer);
        }
        [Route("Customers")]
        public ActionResult Customers()
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
            NewCustomerViewModel viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }


    }
}