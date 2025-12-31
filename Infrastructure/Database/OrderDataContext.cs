using Microsoft.EntityFrameworkCore;
using Orders.Domain.Entities;

namespace Orders.Infrastructure.Database
{
    public class OrderDataContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public OrderDataContext(DbContextOptions<OrderDataContext> options) : base(options)
        {
        }
    }
}
