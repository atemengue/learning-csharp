int numberToBeGuessed = new Random().Next(0, 10);
int remainingChanges = 5;
bool numberFound = false;

Console.WriteLine(numberToBeGuessed);

while (!numberFound && remainingChanges > 0)
{

  try
  {
    Console.WriteLine("Try to catch the correct number");
    int userNumber = int.Parse(Console.ReadLine());

    if (userNumber != numberToBeGuessed)
    {
      remainingChanges--;
      Console.WriteLine($"Try again, the number of chances.{remainingChanges}");
    }
    else
    {
      Console.WriteLine($"Congrats! You've guessed the number with {remainingChanges} chances left!");
      numberFound = true;
    }

    if (remainingChanges == 0)
      Console.WriteLine($"You're out of chances. The number was {numberToBeGuessed}");
  }
  catch (System.FormatException)
  {
    Console.WriteLine("You did not input a number. Let's start again....\n");
    continue;
  }


}

Console.WriteLine(numberToBeGuessed);