using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebChisoft
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}