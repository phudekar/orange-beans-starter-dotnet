using System;
using OrangeBeans.Models;
using OrangeBeans.Repo;

namespace OrangeBeans
{
  public class OrderService
  {

    OrderRepository OrderRepository = new OrderRepository();

    public String PlaceOrder(Order order)
    {
      return "O-" + OrderRepository.SaveOrder(order).ID;
    }

  }
}