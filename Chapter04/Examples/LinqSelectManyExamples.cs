using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04.Examples {

  record City (string Name, IEnumerable<string> Stations);

  public class LinqSelectManyExamples {
    public static void RunLinqSelectManyExamples() {
      
      var cities = new List<City> {
        new City("London", new [] { 
          "Kings Cross KGX",
          "Liverpool Street LVS",
          "Euston EUS"
        }),
        new City("Birmingham", new[] {"New Street NST"})
      };

      Console.WriteLine("All stations");
      foreach (var station in cities.SelectMany(city => city.Stations))
      {
       Console.WriteLine(station) ;
      }

      Console.WriteLine("All Station Codes: ");
      var stations = cities.SelectMany(city => city.Stations.Select(s => s[^3..]));
      foreach (var station in stations) {
        Console.Write($"{station} ");
      }
      Console.WriteLine();
      Console.ReadLine();
    }
  }
}