using Ordering.Application.Services.Orders.Dto;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Services.Orders
{
    public class OrderService : IOrderService
    {
        public Task<bool> DeleteOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertOrderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
