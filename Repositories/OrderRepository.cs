using Microsoft.EntityFrameworkCore;
using Orders.Domain.Entities;
using Orders.Domain.Repositories;
using Orders.Infrastructure.Database;

namespace Orders.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDataContext _context;

        public OrderRepository(OrderDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.AsNoTracking().ToListAsync();
        }

        public async Task<Order?> GetById(int id)
        {
            return await _context.Orders.AsNoTracking().FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}
