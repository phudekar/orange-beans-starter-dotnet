using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using OrangeBeans.Models;

namespace OrangeBeans.Api.Controllers
{
  [Route("api/products")]
  public class ProductsController : Controller
  {
    private readonly Products products;

    public ProductsController(Products products)
    {
      this.products = products;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
      return products;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
      var product = products.Find(p => p.Id == id);
      if (product == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(product);
      }
    }

    [HttpPost]
    public IActionResult Post([FromBody]Product product)
    {
      Product product1 = new Product(Guid.NewGuid().ToString(), product.Name, product.Price);
      products.Add(product1);
      return CreatedAtAction("Get", new { id = product1.Id }, product1);
    }

    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody]Product product)
    {
      var existingProduct = products.Find(p => p.Id == id);
      if (existingProduct == null)
      {
        return NotFound();
      }

      existingProduct.Name = product.Name;
      existingProduct.Price = product.Price;

      return Ok(existingProduct);
    }

    [HttpDelete("{id}")]
    public void Delete(string id)
    {
      var product = products.Find(p => p.Id == id);
      products.Remove(product);
    }
  }
}
