using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MMTShop.Common;
using MMTShop.Models;
using MMTShop.Repositories;

namespace MMTShop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOptions<FeaturedProductsSkuRanges> _featureProductsSku;

        public ProductsController(IProductRepository productRepository, ICategoryRepository categoryRepository, IOptions<FeaturedProductsSkuRanges> featureProductsSku)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _featureProductsSku = featureProductsSku;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }

        [HttpGet]
        public List<Product> GetFeaturedProducts()
        {
            var products = new List<Product>();
            foreach (var item in _featureProductsSku.Value.SkuRanges)
            {
                var category = _categoryRepository.GetCategoryByRange(item.StartRange, item.EndRange);
                if (category == null) continue;
                var product = _productRepository.GetByCategory(category.Name);
                if (product != null)
                {
                    products.AddRange(product);
                }
            }
            return products;
        }

        [HttpGet]
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _productRepository.GetByCategory(category);
        }
    }
}