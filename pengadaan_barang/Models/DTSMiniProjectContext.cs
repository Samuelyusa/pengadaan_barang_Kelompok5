using Client.Models;
using Microsoft.EntityFrameworkCore;

namespace Client.Models
{
    public class DTSMiniProjectContext : DbContext
    {
        public DTSMiniProjectContext(DbContextOptions<DTSMiniProjectContext> dbContext) : base(dbContext)
        {

        }

        public  DbSet<Divisi> Divisi { get; set; }
        public  DbSet<Pengadaan> Pengadaan { get; set; }
        public  DbSet<Product> Product { get; set; }
        public  DbSet<Satuan> Satuan { get; set; }
        public  DbSet<Status> Status { get; set; }
        public  DbSet<Supplier> Supplier { get; set; }
    }
}
