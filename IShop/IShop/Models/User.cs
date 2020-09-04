using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IShop.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public bool IsVendor { get; set; }
        public bool? IsSuperUser { get; set; }
         
    }
    

}