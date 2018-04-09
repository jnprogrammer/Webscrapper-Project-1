using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly5.Models;
using System.Web.Mvc;
using Vidly5.ViewModels;

namespace Vidly5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
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
        
    }
}