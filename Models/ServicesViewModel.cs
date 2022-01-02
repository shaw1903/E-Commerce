using System.Collections.Generic;
using E_Commerce.AutoGen;
using E_Commerce.Data;
using E_Commerce;

namespace E_Commerce.Models
{
  public class ServicesViewModel
  {
    public IEnumerable<Customers> Customer { get; set; } 
    public IList<Orders> Order { get; set; }
  }
}