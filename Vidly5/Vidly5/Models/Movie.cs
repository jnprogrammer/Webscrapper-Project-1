using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Vidly5.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; } 
        public MovieInfo MovieInfo { get; set; }
        public byte MovieInfoId { get; set; }
        
    }
}