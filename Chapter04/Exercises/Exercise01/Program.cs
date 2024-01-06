using System;
using System.Collections;
using System.Collections.Generic;
using Chapter04.Exercises.Exercis01;

namespace Chapter04.Exercises.Exercis01
{

  public static class Program
  {

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
      RunTableExample();
    }





  }


}