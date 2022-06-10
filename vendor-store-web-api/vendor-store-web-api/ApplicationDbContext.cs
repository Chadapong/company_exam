using Microsoft.EntityFrameworkCore;
using vendor_store_web_api.Models;

namespace vendor_store_web_api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
