using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercises.BubbleSort
{
  public class BubbleSort
  {
    public static void Main()
    {

      Console.WriteLine("Entrer array Size");
      // get array size
      int arraySize = Int32.Parse(Console.ReadLine());
      // create empty array

      int[] array = RamdomizedArray(arraySize);

      PrintArray(array);
      Console.WriteLine("")

      int[] sortedArray = BubbleSortArray(array);
      PrintArray(sortedArray);

    }

    public static int[] RamdomizedArray(int arraySize)
    {

      int[] arrayNumber = new int[arraySize];
      // add elements on arrays
      for (var i = 0; i < arrayNumber.Length; i++)
      {
        Random randomValue = new Random();
        arrayNumber[i] = randomValue.Next(0, 300);
      }

      return arrayNumber;

    }

    // BubbleSortArray
    public static int[] BubbleSortArray(int[] array)
    {
      int temp = 0;
      for (var j = 0; j < array.Length - 1; j++)
      {
        if (array[j] > array[j + 1])
        {
          temp = array[j + 1];
          array[j + 1] = array[j];
          array[j] = temp;
        }
      }
      return array;
    }

    // print array
    public static void PrintArray(int[] array)
    {
      for (var i = 0; i < array.Length; i++)
      {
        Console.Write(array[i]);
        Console.Write("  ");
      }
    }
  }
}