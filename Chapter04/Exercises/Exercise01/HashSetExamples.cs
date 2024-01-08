using System;
using System.Collections.Generic;

namespace Chapter04.Exercises.Exercise01.HashSetExamples
{
  public class HashSetExample
  {
    public static void RunHashSetExamples()
    {
      var actors = new List<string> { "Harrison Ford", "Will Smith", "Luffy Mugi" };
      var singers = new List<string> { "Adele", "Will Smith" };
      var actingOrSinging = new HashSet<string>(singers);
      actingOrSinging.UnionWith(actors);
      Console.WriteLine($"Acting or Singing: {string.Join(", ", actingOrSinging)}");
      var actingAndSinging = new HashSet<string>(singers);
      actingAndSinging.IntersectWith(actors);
      // Console.WriteLine($"Acting and Singing: {string.Join(", actingAndSinging)}");
      Console.WriteLine($"Acting and Singing: {string.Join(", ", actingAndSinging)}");
      var actingOnly = new HashSet<string>(actors);
      actingOnly.ExceptWith(singers);
      Console.WriteLine($"Acting only: {string.Join(", ", actingOnly)}");
      Console.ReadLine();


    }
  }
}