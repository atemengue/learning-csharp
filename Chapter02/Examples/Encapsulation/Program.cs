using System;
using Chapter02.Examples.Encapsulation;

public static class Solution
{

  public classs BankAccount
  {
    private decimal _balance;

  public BankAccount(decimal balance)
  {
    _balance = balance;
  }
}

public static bool operator >(BankAccount account1, BankAccount account2) => account1?.balance > account2?.balance;

public static bool operator <(BankAccount account1, BankAccount account2) => account1?.balance < account2?.balance;

// generic
public static void Print<T>(T element)
{
  Console.WriteLine(element);
}

public static void PrintAnyType<T>(T[] elements)
{
  foreach (var element in elements)
  {
    Console.WriteLine(element);
  }
}

public enumf Gender
{
'Male',
'Female',
'Other'
}

public static void Main()
{

  Dog dog = new Dog();

  if (dog.Owner != null)
  {
    bool ownerNameStartsWithA = dog.Owner.StartsWith('A');
    // dog.Owner?.StartsWith('A');
  }

}
}