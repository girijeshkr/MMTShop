using System.Collections.Generic;
using MMTShop.Models;

namespace MMTShop.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
        Product Get(int id);
        IEnumerable<Product> GetByCategory(string category);
        Product Create(Product product);
        Product Update(Product product);
    }
}
