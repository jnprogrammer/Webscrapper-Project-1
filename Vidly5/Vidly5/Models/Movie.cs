using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly5.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; } 
        public MovieInfo MovieInfo { get; set; }
        public byte MovieInfoId { get; set; }
    
    }
}