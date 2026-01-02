using Orders.Domain.Entities;
using Orders.DTOs;

namespace Orders.Domain.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrders(ListOrdersRequest request);
        Task<decimal> CalculateTotalAmount(int orderId);
        Task<int> IniateOrder();
    }
}
