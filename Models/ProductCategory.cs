using Multishop.Models.Base;

namespace Multishop.Models
{
    public class ProductCategory:BaseEntity
    {
        public Product? Product { get; set; }
        public Category? Category { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
