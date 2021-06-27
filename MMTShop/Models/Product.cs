using System.ComponentModel.DataAnnotations;

namespace MMTShop.Models
{
    public class Product
    {
        [Key]
        public int Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}
