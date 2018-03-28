using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly4.Models;
using Vidly4.ViewModels;

namespace Vidly4.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Vires in numeris", Id = 1 };
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
            
        }  
    }
}