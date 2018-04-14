using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly4.Models;

namespace Vidly4.Controllers
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
            var movies = _context.Movies.Include(c => c.MovieDetailModel).ToList();
            return View(movies);
        }

        public ActionResult MovieDetails(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}

/*
 * var movie = new Movie() { Name = "Vires in numeris", Id = 1 };
            var customers = new List<Customer>
            {
                new Customer {Name = "Ada Lovelase"},
                new Customer {Name = "Richard Drew"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
           
            return View(viewModel);
 * 
 */
