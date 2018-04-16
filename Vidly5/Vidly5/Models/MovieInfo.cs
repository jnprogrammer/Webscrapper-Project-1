using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly5.Models
{
    public class MovieInfo
    {
        public byte Id { get; set; }
        public String Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumInStock { get; set; }
    }
}