using Microsoft.EntityFrameworkCore;

namespace VSTCustomer.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<ORDERED> ORDERED { get; set; }
    }
}
