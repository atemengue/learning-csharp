using Exerice_04;
// Console.WriteLine("Type a value for a: ");
// var a = int.Parse(Console.ReadLine());
// Console.WriteLine("Type a value for b:");
// var b = int.Parse(Console.ReadLine());

// Console.WriteLine($"The value of a is  {a} and for b is {b}");
// Console.WriteLine($"Sum is {a + b}");
// Console.WriteLine($"Multipliction is {a * b}");
// Console.WriteLine($"Subtraction is {a - b}");
// Console.WriteLine($"Division is {a / b}");



var person = new Person("Regis", 29);

var person2 = new Person();

var person3 = new Person()
{
  Name = "Fred",
  Age = 9
};

person.GetInfo();

person3.GetInfo();