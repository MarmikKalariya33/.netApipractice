using Microsoft.EntityFrameworkCore;

namespace practice.Models
{
    public class EcomDbContext : DbContext
    {
        EcomDbContext(DbContextOptions<EcomDbContext>options):base(options)
        {

        }
   }
}
