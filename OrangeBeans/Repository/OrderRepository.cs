using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using OrangeBeans.Models;

namespace OrangeBeans.Repo
{
  public class OrderRepository
  {

    private Dictionary<int, Order> orders = new Dictionary<int, Order>();

    public Order SaveOrder(Order order)
    {
      order.ID = orders.Count + 1;
      orders.Add(order.ID, order);
      return order;
    }

    public void UpdateOrder(Order savedOrder)
    {
      orders[savedOrder.ID] = savedOrder;
    }

    public Order GetOrderByPaymentReference(string paymentReference)
    {
      return orders.Values.FirstOrDefault(o => o.PaymentReference == paymentReference);
    }
  }
}