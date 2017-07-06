using System;
using OrangeBeans.Models;
using OrangeBeans.Repo;

namespace OrangeBeans
{

  public class FulfillmentService
  {
    ShippingService shippingService = new ShippingService();
    NotificationService notificationService = new NotificationService();
    private OrderRepository orderRepository;

    public FulfillmentService(OrderRepository orderRepository)
    {
      this.orderRepository = orderRepository;
    }

    public string FulfillOrder(Order order)
    {
      order.Status = OrderStatus.Shipped;
      order.TrackingID = shippingService.SendShipment(order);
      orderRepository.UpdateOrder(order);
      notificationService.Notify(order);

      return order.TrackingID;
    }
  }

}