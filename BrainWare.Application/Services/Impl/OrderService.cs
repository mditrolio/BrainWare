namespace BrainWare.Application.Services.Impl
{
    using System.Collections.Generic;
    using System.Linq;

    using Data;

    using Domain.Models;

    using Microsoft.EntityFrameworkCore;

    public class OrderService : IOrderService
    {
        public OrderService(OrderContext orderContext)
        {
            OrderContext = orderContext;
        }

        private OrderContext OrderContext { get; }

        public IEnumerable<Order> GetOrders()
        {
            var query = OrderContext.Orders.Include(x => x.OrderProducts).ThenInclude(x => x.Product);
            return query.ToList();
        }
    }
}