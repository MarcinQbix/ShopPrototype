using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPrototype.Data.Models
{
   public class Product
    {
        public Product()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductType productType { get; set; }
        public int Stan { get; set; }
    }
}
