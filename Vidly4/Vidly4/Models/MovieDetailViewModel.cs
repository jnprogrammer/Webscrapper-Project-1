using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly4.Models;

namespace Vidly4.Views.ViewModels
{
    public class MovieDetailViewModel
    {
       public String Genre { get; set; }
       public DateTime ReleaseDate { get; set; }
       public DateTime AddDate { get; set; }
       public int UnitsInStock { get; set; }
    }
}