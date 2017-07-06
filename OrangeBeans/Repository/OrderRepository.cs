using System;
using System.Collections;
using System.Collections.Generic;
using OrangeBeans.Models;

namespace OrangeBeans.Repo
{
  public class OrderRepository
  {

    private List<Order> orders = new List<Order>();

    public Order SaveOrder(Order order)
    {
      order.ID = orders.Count;
      this.orders.Add(order);
      return order;
    }

  }
}