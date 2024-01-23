using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercises.BubbleSort
{
  public static class BubbleSort
  {
    public static void Main()
    {

      Console.WriteLine("Entrer array Size");
      // get array size
      int arraySize = Int32.Parse(Console.ReadLine());
      // create empty array
      int[] arrayNumber = new int[arraySize];

      // add elements on arrays

      for (var i = 0; i < arrayNumber.Length; i++)
      {
        Random randomValue = new Random();
        arrayNumber[i] = randomValue.Next(0, 300);
      }

      // print table

      for (var i = 0; i < arrayNumber.Length; i++)
      {
        Console.Write(arrayNumber[i]);
        Console.Write("  ");
      }

      // BubleSort

      for (var i = 0; i < arrayNumber.Length; i++)
      {
        int temp = 0;
        for (var j = 0; j < arrayNumber.Length - 1; j++)
        {
          if (arrayNumber[j] > arrayNumber[j + 1])
          {
            temp = arrayNumber[j + 1];
            arrayNumber[j + 1] = arrayNumber[j];
            arrayNumber[j] = temp;

          }
        }
      }

      Console.WriteLine("------------\n");


      for (var i = 0; i < arrayNumber.Length; i++)
      {
        Console.Write(arrayNumber[i]);
        Console.Write("  ");
      }
    }
  }


}