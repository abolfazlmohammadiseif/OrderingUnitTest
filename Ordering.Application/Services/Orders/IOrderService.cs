﻿using Ordering.Application.Services.Orders.Dto;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Services.Orders
{
    public interface IOrderService
    {
        Task<int> InsertOrderAsync();
        Task<bool> DeleteOrderAsync();
        Task<bool> UpdateOrderStatusAsync(int orderId, OrderStatus status);
        Task<OrderDto> GetAsync();
    }
}