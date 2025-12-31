using Orders.Domain.Entities;

namespace Orders.Domain.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<decimal> CalculateTotalAmount(int orderId);
    }
}
