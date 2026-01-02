using Microsoft.EntityFrameworkCore;
using Orders.Domain.Entities;
using Orders.Domain.Repositories;
using Orders.DTOs.Request;
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

        public async Task<IEnumerable<Order>> GetAll(ListOrdersRequest filter)
        {
            return await _context.Orders
                .AsNoTracking()
                .OrderBy(o => o.Id)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToListAsync();
        }

        public async Task<Order?> GetById(int id)
        {
            return await _context
                .Orders
                .AsNoTracking()
                .Include(o => o.Items)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task IniateOrder(Order order)
        {
            await _context.Orders.AddAsync(order);

            await _context.SaveChangesAsync();
        }
    }
}
