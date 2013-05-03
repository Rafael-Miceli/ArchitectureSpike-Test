using System.Collections.Generic;

namespace ArchitectureSpike.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public List<OrderItem> Items { get; set; } 
    }
}
