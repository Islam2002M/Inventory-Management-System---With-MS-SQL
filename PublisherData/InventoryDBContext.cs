using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{

    public class InventoryDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SD5AB36\\SQLEXPRESS; " +
                                        "Database=Inventory2; User Id=islam; Password=Must@2002Islam;" +
                                        " Encrypt=False;");
        }
        
    }
}