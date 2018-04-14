using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly4.Models;

namespace Vidly4.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public MovieDetailModel MovieDetailModel { get; set; }
        public byte MovieDetailId { get; set; }

    }
}