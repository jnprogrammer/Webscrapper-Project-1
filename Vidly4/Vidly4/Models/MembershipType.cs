using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Vidly4.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }  
        public string MembershipTitle { get; set; }
        public DateTime Birthday { get; set; }
    }
}