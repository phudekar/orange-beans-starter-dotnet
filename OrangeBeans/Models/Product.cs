using System;

namespace OrangeBeans.Models
{

  public class Product
  {

    public string Id { get; private set; }

    public String Name { get; set; }

    public float Price { get; set; }

    public Product(String id, String name, float price){
      this.Id = id;
      this.Name = name;
      this.Price = price;
    }

  }

}