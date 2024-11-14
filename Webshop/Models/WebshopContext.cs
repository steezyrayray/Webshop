using Microsoft.EntityFrameworkCore;

namespace Webshop.Models
{
    public class WebshopContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleOrder> ArticleOrder { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Webshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
