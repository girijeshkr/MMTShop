using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MMTShop.Models;

namespace MMTShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> GetByCategory(string category)
        {
            //return _context.Products.Where(x => x.Category.Equals(category)); //Without Stored Procedure
            return _context.Products.FromSql($"GetProductsByCategory {category}").ToList(); //Using Stored Procedure
        }
        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChangesAsync();
            return product;
        }

        public Product Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return product;
        }

    }
}
