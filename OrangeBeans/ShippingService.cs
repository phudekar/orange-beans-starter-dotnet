using System;
using OrangeBeans.Models;

namespace OrangeBeans
{
  internal class ShippingService
  {
    internal string SendShipment(Order order)
    {
      return "TR-" + order.ID.ToString(); 
    }
  }
}