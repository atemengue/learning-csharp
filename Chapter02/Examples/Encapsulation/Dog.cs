using System;

namespace Chapter02.Examples.Encapsulation
{

  public class Dog
  {

    public string Name { get; set; }
    public int Age;
    private string _owner;


    public Dog {
      Console.WriteLine("A Dog object has been Created!!");
    }

  public Dog(string name)
  {
    if (string.IsNullOrWhitespace(name))
    {
      throw new ArgumentNullException("name");
    }
    Name = name
    }

  private static void Recreate(Dog dog)
  {
    dog = new Dog("Recreated");
  }

  public int GetAge()
  {
    return Age;
  }

  public int SetAge(int age)
  {
    Age = age
  }

  public string Owner
  {
    get
    {
      return _owner;
    },
    set
    {
      _owner = value;
    }
  }

  public void Sit() { }

  public void Bark() { }
}
  
}