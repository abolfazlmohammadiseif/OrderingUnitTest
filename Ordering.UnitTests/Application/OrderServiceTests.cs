using Moq;
using Ordering.Application.Services.Orders;
using Ordering.Application.Services.Orders.Dto;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ordering.UnitTests.Application
{
    public class OrderServiceTests
    {
        private readonly IOrderService _orderService;
        private readonly Mock<IOrderRepository> _orderRepository;
        public OrderServiceTests()
        {
            _orderRepository = new Mock<IOrderRepository>();
            _orderService = new OrderService(_orderRepository.Object);
        }
        [Fact]
        public async Task InsertOrder_GivenModel_ReturnId()
        {
            //Assert
            OrderDto orderDto = new OrderDto();

            var result = await _orderService.InsertOrderAsync(orderDto);

            Assert.NotNull(result);
        }
    }
}
