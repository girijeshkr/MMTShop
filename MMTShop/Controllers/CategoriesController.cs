using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MMTShop.Models;
using MMTShop.Repositories;

namespace MMTShop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return  _categoryRepository.Get();
        }
        [HttpGet]
        public IEnumerable<string> GetNames()
        {
            return _categoryRepository.Get().Select(x => x.Name);
        }
    }
}