using Multishop.Models.Base;

namespace Multishop.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }
    }
}
