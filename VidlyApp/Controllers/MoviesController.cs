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
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        List<Movie> MoviesList = new List<Movie>
            {
                new Movie{Name = "Robin Hood", Id = 0 },
                new Movie{Name = "Creed II", Id = 1},
                new Movie{Name = "Disobedience", Id = 2 },
                new Movie{Name = "Coco", Id = 3 }
            };
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public MoviesController()
        {
            _context = new ApplicationDbContext();
            MoviesList = _context.Movies.Include(m => m.Genre).ToList();
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!", Id = 0 };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = new List<Customer>()
            };

            var viewResult = new ViewResult();

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var viewModel = new MoviesViewModel()
            {
                Movies = MoviesList
            };
            return View(viewModel);
        }

      //  [Route("Movies/{id:int}")]
        public ActionResult Details(int? Id)
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