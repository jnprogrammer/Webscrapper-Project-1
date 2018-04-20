using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly5.Models;

namespace Vidly5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.MovieInfo).ToList();
            return View(movies);
        }
       
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        
    }
}


/*public ActionResult Random()
        {
            var movie = new Movie() { Name = "stuff" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Josh is"},
                new Customer {Name = "Getting Hired"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        */