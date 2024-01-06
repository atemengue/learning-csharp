using System;
using System.Collections;
using System.Collections.Generic;
using Chapter04.Exercises.Exercise01.QueueExample;
using Chapter04.Exercises.Exercise01.TabExample;

namespace Chapter04.Exercises.Exercise01
{

  public static class Program
  {

    public static void RunQueueExample()
    {

      var ticketsAvailable = 10;
      var customers = new Queue<CustomerOrder>();

      customers.Enqueue(new CustomerOrder("Regis", 1));
      customers.Enqueue(new CustomerOrder("Dave", 2));
      customers.Enqueue(new CustomerOrder("Siva", 4));
      customers.Enqueue(new CustomerOrder("Julien", 3));
      customers.Enqueue(new CustomerOrder("Kane", 2));

      // starting processsing orders
      while (customers.TryDequeue(out CustomerOrder nextOrder))
      {
        if (nextOrder.TicketsRequested < ticketsAvailable)
        {
          ticketsAvailable -= nextOrder.TicketsRequested;
          Console.WriteLine($"Congratulations {nextOrder.Name}, you've purchased {nextOrder.TicketsRequested} ticket(s)");
        }
        else
        {
          Console.WriteLine($"Sorry {nextOrder.Name},cannot fulfil {nextOrder.TicketsRequested} ticket(s)");
        }

      }

      Console.WriteLine($"Finished.Available={ticketsAvailable}");
      Console.ReadLine();

    }

    public static void RunTableExample()
    {

      var controller = new TabController();
      Console.WriteLine("Opening tabs...");
      var packt = controller.OpenNew("packtpub.com");
      var msoft = controller.OpenNew("microsoft.com");
      var amazon = controller.OpenNew("amazon.com");
      controller.LogTabs();
      Console.WriteLine("Moving...");
      controller.MoveToStart(amazon);
      controller.MoveToEnd(packt);
      controller.LogTabs();
      Console.WriteLine("Closing tab...");
      controller.Close(msoft);
      controller.LogTabs();
      Console.ReadLine();

    }

    private static void LogTabs(this IEnumerable<Tab> tabs)
    {
      Console.Write("TABS: |");
      foreach (var tab in tabs)
        Console.Write($"{tab.Url.PadRight(15)}|");

      Console.WriteLine();
    }

    public static void Main()
    {
      // RunTableExample();
      RunQueueExample();
    }





  }


}