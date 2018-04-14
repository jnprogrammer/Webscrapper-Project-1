using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Vidly4.Models;

namespace Vidly4.Models
{
    public class MovieDetailModel
    {
        [Required]  
        public byte Id { get; set; }
        [Required]
        public String Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime AddDate { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
    }
}