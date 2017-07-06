using System;
using OrangeBeans.Models;

namespace OrangeBeans
{
  public class NotificationService
  {
    public void Notify(Order order)
    {
      switch (order.Status)
      {
        case OrderStatus.Pending:
          Console.WriteLine($"Order {order.ID} is Pending for Payment");
          break;
        case OrderStatus.Shipped:
          Console.WriteLine($"Order {order.ID} is Shipped");
          break;
        default:
          Console.WriteLine($"Order {order.ID} is Accepted");
          break;
      }
    }
  }
}