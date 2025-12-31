using Orders.Domain.Entities;

namespace Orders.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<Order?> GetById(int id);
        Task<IEnumerable<Order>> GetAll();
    }
}
