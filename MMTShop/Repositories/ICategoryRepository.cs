using System.Collections.Generic;
using MMTShop.Models;

namespace MMTShop.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Get();
        Category GetCategoryByRange(int startRange, int endRange);
    }
}
