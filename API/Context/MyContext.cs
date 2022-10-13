using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<Divisi> Divisi { get; set; }
        public DbSet<Pengadaan> Pengadaan { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Satuan> Satuan { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
    }
}
