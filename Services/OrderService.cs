using Orders.Domain.Entities;
using Orders.Domain.Enums;
using Orders.Domain.Repositories;
using Orders.Domain.Services;
using Orders.DTOs;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<decimal> CalculateTotalAmount(int orderId)
        {
            Order? order = await _repository.GetById(orderId) ?? throw new Exception("Order not found");

            decimal totalAmount = 0;

            totalAmount = order.Items.Sum(item => item.UnitPrice * item.Quantity);

            return totalAmount;
        }

        public async Task<IEnumerable<Order>> GetAllOrders(ListOrdersRequest request)
        {
            return await _repository.GetAll(request);
        }

        public async Task<int> IniateOrder()
        {
            var order = new Order
            {
                CreatedAt = DateTime.UtcNow,
                Status = EnumOrderStatus.CREATED,
            };

            await _repository.IniateOrder(order);

            return order.Id;
        }
    }
}
