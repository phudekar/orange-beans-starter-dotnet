using System;
using System.Collections.Generic;

namespace OrangeBeans.Models
{
  public class Order
  {
    public int ID { get; set; }

    public Dictionary<Product, int> Products { get; set; }

  }
}
