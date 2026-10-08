using Microsoft.EntityFrameworkCore;

namespace practice.Models
{
    public class EcomDbContext : DbContext
    {
        public EcomDbContext(DbContextOptions<EcomDbContext> options)
            : base(options)
        {
        }

        public DbSet<productMaster> productMasters { get; set; }

        public DbSet<categoryModel> categoryModels { get; set; }
    }
}