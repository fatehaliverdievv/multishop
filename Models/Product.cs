using Multishop.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Multishop.Models
{
    public class Product : BaseEntity
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [Range(0.0, 10000)]
        public double CostPrice { get; set; }
        [Range(0.0, 10000)]
        public double SellPrice { get; set; }
        public int DiscountId { get; set; }
        public Discount? Discount { get; set; }
        public ProductInformation? ProductInformation { get; set; }
        public int ProductInformationId { get; set; }
        public ICollection<Color>? Colors { get; set; }
        public ICollection<Size>? Sizes { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductImage>? ProductImages { get; set;}
    }
}
