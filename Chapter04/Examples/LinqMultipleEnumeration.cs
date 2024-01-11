using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04.Examples
{

  public class ListMultipleEnumeration
  {

    record Travelog(string Name, int Distance, int Duration)
    {
      public double AverageSpeed()
      {

        Console.WriteLine($"AverageSpeed() called for '{Name}'");
        return Distance / Duration;
      }
    }

    public static void RundListMultipleEnumeration()
    {

      var travellogs = new List<Travelog>{
        new Travelog("Bertoua Yaounde", 100, 5 ),
        new Travelog("Yaounde Douala", 300, 24),
        new Travelog("Yaounde Bafoussam", 1146, 19),
        new Travelog("Bertoua Ngaoundere", 546, 19)
      };

      var fastedJourneys = travellogs.Where(t => t.AverageSpeed() > 50);
      Console.WriteLine("Fastest Distance");

      foreach (var item in fastedJourneys)
      {
        Console.WriteLine($"{item.Name} --- {item.Distance} miles");
      }

      Console.WriteLine("Fastest Duration");

      foreach (var item in fastedJourneys)
      {
        Console.WriteLine($"{item.Name} --- {item.Duration} hours");
      }

      Console.WriteLine("Fasted Duretion multiples loop");

      var fastedJourneysList = travellogs.Where(t => t.AverageSpeed() > 50).ToList();
      for (var i = 0; i < 2; i++)
      {
        Console.WriteLine("Fasted Duration Multiple Loop iteration loop (i = 1)");
        foreach (var item in fastedJourneysList)
        {
          Console.WriteLine($"{item.Name} : {item.Distance} in {item.Duration} hours");
        }
      }


    }

  }

}