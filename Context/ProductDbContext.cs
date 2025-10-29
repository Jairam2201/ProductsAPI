using ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductsAPI.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        { 
        }

        public DbSet<Product>Products { get; set; }
        public DbSet<ExternalApiLog> ExternalApiLogs { get; set; }
    }
}
