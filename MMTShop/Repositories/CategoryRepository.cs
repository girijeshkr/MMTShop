using System.Collections.Generic;
using System.Linq;
using MMTShop.Models;

namespace MMTShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext _context;

        public CategoryRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Get()
        {
            return  _context.Categories.ToList();
        }
        public Category GetCategoryByRange(int startRange, int endRange)
        {
            return  _context.Categories.FirstOrDefault(x => x.StartRange == startRange && x.EndRange == endRange);
        }
    }
}
