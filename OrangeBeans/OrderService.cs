using System;
using OrangeBeans.Models;
using OrangeBeans.Repo;

namespace OrangeBeans
{
  public class OrderService
  {
    PaymentService paymentService = new PaymentService();
    private OrderRepository orderRepository;
    private FulfillmentService fulfillmentService;
    private NotificationService notificationService;

    public OrderService()
    {
      orderRepository = new OrderRepository();
      notificationService = new NotificationService();
      fulfillmentService = new FulfillmentService(orderRepository);
    }

    public String PlaceOrder(Order order)
    {
      order.Status = OrderStatus.Accepted;
      Order savedOrder = orderRepository.SaveOrder(order);
      savedOrder.PaymentReference = paymentService.ProcessPayment(savedOrder);
      orderRepository.UpdateOrder(savedOrder);
      notificationService.Notify(savedOrder);
      return savedOrder.PaymentReference;
    }

    public String CompleteOrder(String paymentReference)
    {
      var order = orderRepository.GetOrderByPaymentReference(paymentReference);
      order.Status = OrderStatus.Pending;
      orderRepository.UpdateOrder(order);
      notificationService.Notify(order);
      return fulfillmentService.FulfillOrder(order);
    }

  }
}