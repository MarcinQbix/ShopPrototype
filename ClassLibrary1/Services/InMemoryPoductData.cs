using ShopPrototype.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopPrototype.Data.Services
{
    public class InMemoryPoductData : IProductData
    {
        List<Product> products;
        public InMemoryPoductData()
        {
            products = new List<Product>()
            {
                new Product{Id=1,Name="Persil",Description="Środek DO Prania",Price=22.0,productType=ProductType.CHEMIA,Stan=10 },
                  new Product{Id=2 ,Name="Nivea Krem",Description="Krem Do Rąk",Price=3.5,productType=ProductType.KOSMETYKI ,Stan=14},
                 new Product{Id=3,Name="Malboro Czerwone",Description="Papierosy",Price=15.0,productType=ProductType.PAPIEROSY,Stan=7 }

            };
        }
        public IEnumerable<Product> GetAll()
        {
          
            return products.OrderBy(p => p.Name);
        }
    }
}
