﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly4.Models;

namespace Vidly4.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}