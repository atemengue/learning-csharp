using System;
using System.Linq;

namespace Chapter04.Examples
{
  class LinqSkipTakeExamples
  {

    public static void RunLinqSkipTakeExample()
    {
      var grades = new[] { 57, 38, 24, 99, 19, 0, 19, 3 };
      Console.WriteLine("Skip Highest Grades  {skipping first}: ");
      foreach (var grade in grades.OrderByDescending(g => g).Skip(1))
        Console.WriteLine($"{grade}");

      Console.WriteLine("");
      Console.WriteLine("SkipWhile@ Middle Grades (Excluding 99 10)");

      foreach (var grade in grades.OrderByDescending(g => g).SkipWhile(g => g is <= 20 or >= 38))
        Console.WriteLine($"{grade}");

      Console.WriteLine("");

      Console.Write("SkipLast: Bottom Half Grades:");

      foreach (var grade in grades.OrderByDescending(g => g).SkipLast(grades.Length / 2))
        Console.WriteLine($"{grade}");

      Console.WriteLine("");
      Console.WriteLine("Take to Highest Grades");
      foreach (var grade in grades.OrderByDescending(g => g).Take(3))
        Console.WriteLine($"{grade}");
    }
  }

}