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

      // Linq Query Operators

      var query4 = from day in days
                   select day + "day";
      
      foreach (var day in query4)
        Console.WriteLine($"Query Operartor: {day}");
                

      var query2 = days.Select((d, i) => $"{i} : {d}day");
      foreach(var day in query2)
        Console.WriteLine($"Query2: {day}");

      // ANONYMOUS TYPES
      var query3 = days.Select((d, i) => new {
        Index = i,
        UpperCaseName = $"{d.ToUpper()}DAY"
      });
      foreach (var day in query3)
        Console.WriteLine($"Query3: Index={day.Index}, UpperCaseDay={day.UpperCaseName}");

      // Mixes a Query Operator and Query Expressions

      var query5 = from dayIndex in days.Select((d, i) => new {Name = d, Index = i})
                   select dayIndex;
                    
      foreach (var day in query5)
        Console.WriteLine($"Query5: Index={day.Index} : {day.Name}");

    
      Console.ReadLine();
    }
  }
}