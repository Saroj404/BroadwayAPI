using Microsoft.EntityFrameworkCore;

namespace BroadwayAPI.Model
{
    public class EfContext : DbContext
    {
        public DbSet<Country> Country { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {

        }


    }
    
}
