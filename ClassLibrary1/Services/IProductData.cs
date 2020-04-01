using ShopPrototype.Data.Models;
using System.Collections.Generic;
using System.Text;

namespace ShopPrototype.Data.Services
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
    }
}
