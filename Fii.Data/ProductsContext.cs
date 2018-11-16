using Microsoft.EntityFrameworkCore;

namespace Fii.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Products> Products { get; set; }
    }
}
