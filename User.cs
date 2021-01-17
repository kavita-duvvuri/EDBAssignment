using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class User
    {
        public Guid  UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string  PhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public int Age { get; set; }
        
    }
}