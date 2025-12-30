using Orders.Domain.Enums;

namespace Orders.Domain.Entities
{
    public class Order
    {
        public long Id { get; set;  }
        public DateTime CreatedAt { get; set; }
        public EnumOrderStatus Status { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
    }
}
