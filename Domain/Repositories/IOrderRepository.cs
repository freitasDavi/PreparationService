using Orders.Domain.Entities;
using Orders.DTOs.Request;

namespace Orders.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<Order?> GetById(int id);
        Task<IEnumerable<Order>> GetAll(ListOrdersRequest filters);
        Task IniateOrder(Order order);
    }
}
