using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04.Examples {
    
  public class LinqSelectExamples {

    public static void RunLinqSelectExamples() {
      var days = new List<string> { "Mon", "Tues", "Wednes" };
      var query1  = days.Select(d => d + "day");
      foreach(var day in query1)
        Console.WriteLine($"Query1: {day}");

      var query2 = days.Select((d, i) => $"{i} : {d}day");
      foreach(var day in query2)
        Console.WriteLine($"Query2: {day}");

    }
  }
}