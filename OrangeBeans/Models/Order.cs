using System;
using System.Collections.Generic;

namespace OrangeBeans.Models
{
  public class Order
  {
    public int ID { get; set; }
    public Dictionary<Product, int> Products { get; set; }
    public string PaymentReference { get; internal set; }
    public OrderStatus Status { get; internal set; }
    public string TrackingID { get; internal set; }
    public Address Address { get; set; }

    public Order(){
      Products = new Dictionary<Product,int>();
    }
  }
}
