using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly4.Models;

namespace Vidly4.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Ada Lovelace", Id = 1 };
            //return View(movie);
            // return Content("I'm here for the first time");
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
    }
}