using System;
using System.Collections.Generic;

namespace Chapter04.Exercises.Exercise01.DictionnaryExamples
{

  public record Country(string Name);
  class DictionnaryExample
  {
    public static void RunDictionnaryExample()
    {

      var countries = new Dictionary<string, Country>{
      { "CMR", new Country("Cameroun")},
      { "FR", new Country("France")},
      { "IVR", new Country("Cote d'Ivoire")},
      { "AND", new Country("Andora")},
      { "CAN", new Country("Canada")}
    };

      Console.WriteLine("Enumerate KeyPairValue");
      foreach (var kvp in countries)
      {
        Console.WriteLine($"\t{kvp.Key} = {kvp.Value.Name}");
      }

      Console.WriteLine("set indexor of CMR to new value");
      countries["CMR"] = new Country("Le contiment Cameroun");
      Console.WriteLine($"Get indexor CMR: {countries["CMR"].Name}");

      Console.WriteLine($"Contains Keys {"FR"}: {countries.ContainsKey("FR")}");
      Console.WriteLine($"Contains Keys {"AND"}: {countries.ContainsKey("AND")}");

      var anguilla = new Country("Anguilla");
      Console.WriteLine($"Adding {anguilla} ....");
      countries.Add("AIA", anguilla);

      try
      {
        var anguillaCopy = new Country("Anguilla");
        Console.WriteLine($"Adding {anguilla} ....");
        countries.Add("AIA", anguillaCopy);

      }
      catch (System.Exception e)
      {

        Console.WriteLine($"Caught {e.Message}");
      }

      var addIAI = countries.TryAdd("AIA", new Country("Anguilla"));
      Console.WriteLine($"tryAdd AIA: {addIAI}");

      var tryGet = countries.TryGetValue("AND", out Country andora1);

      Console.WriteLine($"TryGetValue for AND: {andora1} Result={tryGet}");
      countries.TryGetValue("alb", out Country andora2);
      Console.WriteLine($"TryGetValue for AND: {andora2}");
    }

  }
}