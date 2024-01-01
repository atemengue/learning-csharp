using System;

namespace Chapter02.Exercise.Exercise2_01
{

  public class Person
  {
    private string _owner;
    public string Owner
    {
      get
      {
        return _owner;
      }

      set
      {
        _owner = value;
      }
    }

    public string Name { get; private set; }
    public Person(string name)
    {
      if (string.IsNullOrWhiteSpace(name))
      {
        throw new ArgumentNullException("name");
      }
      Name = name;
    }
  }



}