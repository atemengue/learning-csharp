using System;
using System.IO;
using System.Linq;

namespace Chapter04.Examples
{
  class LinqOrderByExamples
  {
    public static void RunLinqOrderByExamples()
    {

      var path = $"{Directory.GetCurrentDirectory()}/Examples/tmp";
      var fileInfos = Directory.EnumerateFiles(path, "*.tmp")
        .Select(filename => new FileInfo(filename))
        .ToList();

      Console.WriteLine("Earliest Files");
      foreach (var fileInfo in fileInfos.OrderBy(fi => fi.CreationTime))
      {
        Console.WriteLine($"{fileInfo.CreationTime: dd MM yy}: {fileInfo.Name}");
      }

      Console.WriteLine("Largest Files ");
      foreach (var fileInfo in fileInfos.OrderByDescending(fi => fi.Length))
      {
        Console.WriteLine($"{fileInfo.Length:N0} bytes: \t {fileInfo.Name}");
      }

      Console.WriteLine("Largest smaller Files");
      foreach (var fileInfo in from fi in fileInfos where fi.Length < 1000 orderby fi.Length descending select fi)
      {
        Console.WriteLine($"{fileInfo.Length:N0} bytes: \t{fileInfo.Name}");
      }




    }
  }
}