using Microsoft.EntityFrameworkCore;

namespace MMTShop.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Home", StartRange = 10000, EndRange = 19999},
                new Category {Id = 2, Name = "Garden", StartRange = 20000, EndRange = 29999},
                new Category {Id = 3, Name = "Electronics", StartRange = 30000, EndRange = 39999},
                new Category {Id = 4, Name = "Fitness", StartRange = 40000, EndRange = 49999},
                new Category {Id = 5, Name = "Toys", StartRange = 50000, EndRange = 59999});
            modelBuilder.Entity<Product>().HasData(
                new Product {Sku = 12000, Name = "A", Description = "TestA", Price = 100, Category = "Home"},
                new Product {Sku = 13000, Name = "B", Description = "TestB", Price = 100, Category = "Home"},
                new Product {Sku = 22000, Name = "C", Description = "TestC", Price = 100, Category = "Garden"},
                new Product {Sku = 23000, Name = "D", Description = "TestD", Price = 100, Category = "Garden"},
                new Product {Sku = 32000, Name = "E", Description = "TestE", Price = 100, Category = "Electronics"},
                new Product {Sku = 33000, Name = "F", Description = "TestF", Price = 100, Category = "Electronics"},
                new Product {Sku = 42000, Name = "G", Description = "TestG", Price = 100, Category = "Fitness"},
                new Product {Sku = 43000, Name = "H", Description = "TestH", Price = 100, Category = "Fitness"},
                new Product {Sku = 52000, Name = "I", Description = "TestI", Price = 100, Category = "Toys"},
                new Product {Sku = 53000, Name = "J", Description = "TestJ", Price = 100, Category = "Toys"});
        }
    }
}