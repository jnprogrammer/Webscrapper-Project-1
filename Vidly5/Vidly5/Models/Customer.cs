using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly5.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        public DateTime BirthDay { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }  
    }
}