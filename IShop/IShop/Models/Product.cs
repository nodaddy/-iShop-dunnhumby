using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double  Price { get; set; }
        public int  UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public string Description { get; set; }
        public bool? InStock { get; set; }

        public Product()
        {
            this.Description = "Description";
        }
    }

    
}