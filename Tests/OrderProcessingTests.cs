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

      reference.Should().Be("PR-1");
    }

    [Fact]
    public void CompleteOrderTest()
    {
      var service = new OrderService();
      Order order = new Order();

      var reference = service.PlaceOrder(order);
      var trackingID = service.CompleteOrder(reference);

      trackingID.Should().Be("TR-1");
    }
  }
}
