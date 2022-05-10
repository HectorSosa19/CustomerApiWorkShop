using Microsoft.EntityFrameworkCore;
using WorkShopApi.Model;

namespace WorkShopApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CustomerModel> customerModels { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
