
using Microsoft.EntityFrameworkCore;

namespace practice.Models
{
    public class EcomDbContext : DbContext
    {
        public EcomDbContext(DbContextOptions<EcomDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoryModel> CategoryModels { get; set; }
        public DbSet<productModel> productModels { get; set; }
    }
}
