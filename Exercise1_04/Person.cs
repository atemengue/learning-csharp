namespace Exerice_04
{

  public class Person
  {

    public string Name { get; set; }
    public int Age { get; set; }
    public Person()
    {

    }

    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public bool IsChild()
    {
      return Age < 12;
    }

    public void GetInfo()
    {
      Console.WriteLine($"Name: {Name} IsChild? {IsChild()}");
    }

  }
}