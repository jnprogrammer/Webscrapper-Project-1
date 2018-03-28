using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly4.Models;

namespace Vidly4.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}