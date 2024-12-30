using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{

    public class InventoryDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SD5AB36\\SQLEXPRESS; " +
                                        "Database=Inventory2; User Id=islam; Password=Must@2002Islam;" +
                                        " Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().OwnsOne(p => p.Price);
        }
    }
}