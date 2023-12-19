Console.WriteLine("Please type username. It must have at least 6 characteres: ");
string username = Console.ReadLine();

if (username.Length < 6)
{
  Console.WriteLine($"Username {username} is not valid");
}
else
{
  Console.WriteLine("Now type a password, It must have at least 6 characters and also contain a number");

  var password = Console.ReadLine();

  if (password.Length < 6)
  {
    Console.WriteLine("Invalid password");
  }
  else if (!password.Any(c => char.IsDigit(c)))
  {
    Console.WriteLine("password must contains at least one number");
  }
  else
  {
    Console.WriteLine("User successfully registered!!");
  }
}
