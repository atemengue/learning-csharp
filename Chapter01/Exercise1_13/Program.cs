static double Divide(int a, int b)
{
  return a / b;
}

bool divisionExecuted = false;

while (!divisionExecuted)
{

  try
  {
    Console.WriteLine("Please enter the number a: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the number b: ");
    int b = int.Parse(Console.ReadLine());

    var result = Divide(a, b);

    Console.WriteLine($"Result: {result}");

    divisionExecuted = true;
  }
  catch (System.FormatException)
  {
    Console.WriteLine("You did not input a number. Let's start again ... \n");
    continue;
  }
  catch (System.DivideByZeroException)
  {
    Console.WriteLine("Tried to divide by zero. Let's start again ... \n");
    continue;

  }
}