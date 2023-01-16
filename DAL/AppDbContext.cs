using Microsoft.EntityFrameworkCore;
using Multishop.Models;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Reflection;

namespace Multishop.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Models.Color> Colors { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ProductInformation> ProductInformations { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Addvertising> Addvertisings { get; set; }
    }
}
