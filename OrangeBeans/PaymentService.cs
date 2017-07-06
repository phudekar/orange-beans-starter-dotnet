using System;
using OrangeBeans.Models;

namespace OrangeBeans {

  public class PaymentService
  {
    PaymentGateway gateway = new PaymentGateway();
    public string ProcessPayment(Order order)
    {
      float total = 0;

      foreach(var product in order.Products.Keys){
        var quantity = order.Products[product];
        total += product.Price * quantity;
      }

      return "PR-" + gateway.InitiatePayment(total, order.ID);
    }
  }

}