// var numbers = new int[5];

// int[] array = { 1, 2, 3, 4, 5 };

// for (int i = 0; i < array.Length; i++)
// {
//   Console.WriteLine(array[i]);
// }

static int[] BubleSort(int[] array)
{

  int temp;

  for (int j = 0; j < array.Length - 1; j++)
  {

    for (int i = 0; i < array.Length - j - 1; i++)
    {

      if (array[i] > array[i + 1])
      {
        temp = array[i + 1];
        array[i + 1] = array[i];
        array[i] = temp;
      }
    }

  }
  return array;
}

int[] randomNumbers = { 123, 22, 53, 91, 787, 0, -23, 5 };

int[] sortedArray = BubleSort(randomNumbers);

Console.WriteLine("Sorted Elements:");

for (int i = 0; i < sortedArray.Length; i++)
{
  Console.Write(sortedArray[i] + " ");
}

string[] letters = { "a", "b", "c", "d", "e" };

Console.WriteLine("Letters Elements");

foreach (string letter in letters)
{
  Console.Write(letter + " ");
}