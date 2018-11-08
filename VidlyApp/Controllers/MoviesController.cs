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
        private List<Movie> MoviesList;
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
            Random r = new Random();
            var movie = MoviesList[r.Next(0, MoviesList.Count)];

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
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content($"{year}/{month}");
        //}

    }
}