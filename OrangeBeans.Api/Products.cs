using System;
using System.Collections.Generic;
using OrangeBeans.Models;

namespace OrangeBeans.Api
{

  public class Products : List<Product>
  {
    public Products()
    {
      this.Add(new Product(Guid.NewGuid().ToString(), "TV", 21030f));
      this.Add(new Product(Guid.NewGuid().ToString(), "Fridge", 16000f));
      this.Add(new Product(Guid.NewGuid().ToString(), "AC", 35000f));
    }
  }
}