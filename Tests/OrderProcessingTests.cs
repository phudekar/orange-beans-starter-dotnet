using System;
using FluentAssertions;
using OrangeBeans.Models;
using Xunit;

namespace OrangeBeans.Tests
{
  public class OrderProcessingTests
  {
    [Fact]
    public void ProcessOrderTest()
    {
      var service = new OrderService();
      Order order = new Order();

      var reference = service.PlaceOrder(order);

      reference.Should().Be("O-0");

    }
  }
}
