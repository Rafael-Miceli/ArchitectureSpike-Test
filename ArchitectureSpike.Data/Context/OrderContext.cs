using System.Data.Entity;
using ArchitectureSpike.Domain.Models;

namespace ArchitectureSpike.Data.Context
{
    public class OrderContext: BaseContext<OrderContext>
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
