using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04.Examples
{

  public class LinqWhereExamples
  {

    record Order(string Product, int Quantity, double Price);
    public static void RunLinqWhereExamples()
    {
      var orders = new List<Order>{
        new Order("Pen", 3, 1.99),
        new Order("Book", 10, 6),
        new Order("Note Pad", 5, 10),
        new Order("Pencil", 6, 2.99)
      };
      Console.WriteLine("Orders with quantity over 5");
      foreach (var order in orders.Where(o => o.Quantity > 5))
      {
        Console.WriteLine(order);
      }

      Console.WriteLine("Pen or Pencil");

      foreach (var order in orders.Where(o => o.Product == "Pen" || o.Product == "Book")
      .Select(o => o.Quantity * o.Price))
      {
        Console.WriteLine(order);
      }

      var query = from order in orders
                  where order.Price < 3
                  select new { Name = order.Product, Value = order.Quantity * order.Price };

      Console.WriteLine("Cheapset Orders");
      foreach (var order in query)
      {
        Console.WriteLine($"{order.Name}: {order.Value}");

      }
    }
  }

}