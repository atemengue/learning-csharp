static void FormatString(string stringFormat)
{
  stringFormat.Replace("World", "Mars");
}

string FormatReturningString(string stringFormat)
{
  return stringFormat.Replace("Earth", "Mars");
}

var greetings = "Hello World";
FormatString(greetings);
Console.Write(greetings);

var anotherGreeting = "Good norming Earth";
Console.WriteLine(FormatReturningString(anotherGreeting));

string first = "Hello.";
string second = first;
first = null;

Console.WriteLine(first == second);
Console.WriteLine(string.Equals(first, second));


// declaration of float and double

float myFloat = 10f;
double myDouble = 10d;