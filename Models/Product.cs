using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public string img { get; set; }
        public string AllergyInfo { get; set; }
        public string Ingredients { get; set; }
    }
}
