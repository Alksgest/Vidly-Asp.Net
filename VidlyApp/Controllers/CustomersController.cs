using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> CustomersList = new List<Customer>
            {
                new Customer{Name = "John Smith", Id = 0 },
                new Customer{Name = "Mary Williams", Id = 1 },
                new Customer{Name = "Vladyslav Kyrychenko", Id = 2 },
                new Customer{Name = "Vlad Noda", Id = 3 }
            };

        List<Movie> MoviesList = new List<Movie>
            {
                new Movie{Name = "Robin Hood", Id = 0 },
                new Movie{Name = "Creed II", Id = 1},
                new Movie{Name = "Disobedience", Id = 2 },
                new Movie{Name = "Coco", Id = 3 }
            };

        [Route("Customers/{id:int}")]
        public ActionResult Index(int? Id)
        {
            if (!Id.HasValue)
                Id = 1;

            var viewModel = CustomersList[Id.Value - 1];

            return View(viewModel);
        }
        [Route("Customers")]
        public ActionResult Customers()
        {
            var viewModel = new CustomersViewModel()
            {
                Customers = CustomersList
            };
            return View(viewModel);
        }

    }
}