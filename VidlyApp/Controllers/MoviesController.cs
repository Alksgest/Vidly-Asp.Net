﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        List<Customer> CustomersList = new List<Customer>
            {
                new Customer{Name = "John Smith" },
                new Customer{Name = "Mary Williams" },
                new Customer{Name = "Vladyslav Kyrychenko" },
                new Customer{Name = "Vlad Noda" }
            };

        List<Movie> MoviesList = new List<Movie>
            {
                new Movie{Name = "Robin Hood", Id = 0 },
                new Movie{Name = "Creed II", Id = 1},
                new Movie{Name = "Disobedience", Id = 2 },
                new Movie{Name = "Coco", Id = 3 }
            };

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!", Id = 0 };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = CustomersList
            };

            var viewResult = new ViewResult();

            return View(viewModel);
        }

        [Route("Movies")]
        public ActionResult Movies()
        {
            var viewModel = new MoviesViewModel()
            {
                Movies = MoviesList
            };
            return View(viewModel);
        }

        [Route("Movies/{id:int}")]
        public ActionResult Index(int? Id)
        {
            if (!Id.HasValue)
                Id = 1;

            var viewModel = MoviesList[Id.Value - 1];
            return View(viewModel);

        }

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content($"{year}/{month}");
        //}

    }
}