namespace BrainWare.Application.Services
{
    using System.Collections.Generic;

    using Domain.Models;

    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
    }
}