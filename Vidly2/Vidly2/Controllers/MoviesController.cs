using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Big Short" };
            var customers = new List<Customer>
            {
                new Customer{Name="Customer BTC"},
                new Customer{Name="Customer ADA"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
           
        }

       /* [Route("movies/released/{year}/{month:regex(\\d{4}}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month); 
        }*/
        
    }
}

//return View(movie);
//return Content("Send me BTC and I'll Hodl for you!! GUARANTEED!!");
//return HttpNotFound();
//return new EmptyResult();
//viewResult.ViewData.Model;

//return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
/*
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }


            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/
