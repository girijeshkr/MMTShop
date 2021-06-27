using System.ComponentModel.DataAnnotations;

namespace MMTShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartRange { get; set; }
        public int EndRange { get; set; }
    }
}
