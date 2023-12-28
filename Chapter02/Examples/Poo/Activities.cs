using System;

namespace Chapter02.Examples.Poo
{

  public class LoginService
  {
    private string[] _usernames;
    private string[] _passwords;

    public bool Login(string username, string _password)
    {
      // Do a password lookup based on username
      bool isLoggedIn = true;
      return isLoggedIn;
    }
  }

  public abstract class Human
  {
    public string Name { get; }
    public int Age { get; }
    public float Weight { get; }
    public float Height { get; }


    // first contrusctor
    public Human(string name, int age, float weight, float height)
    {
      this.Name = name;
      this.Age = age;
      this.Height = height;
      this.Weight = weight;
    }

    protected Human(string name)
    {
      Name = Name;
    }

    public abstract void Work();

    public override string String()
    {
      return $"{nameof(Name)}: {Name}," +
             $"{nameof(Age)}: {Age}, " +
             $"{nameof(Weight)}: {Weight}" +
             $"{nameof(Height)}: {Height}";
    }
  }
  public class Mailman : Human
  {
    public Mailman(string name, int age, float weight, float height) : base(name, age, weight, height) { }

    public void DeliverMail(Mail mail)
    {

    }

    public override void Work()
    {
      Console.WriteLine("A mailman is delivering mails.")
        // throw new System.NotImplementedException();
      }
  }

  public class Mail
  {
    public string Message { get; }
    public string Addresss { get; }

    public Mail(string message, string address)
    {
      Message = message;
      Addresss = address;
    }
  }

  public class Teacher : Human
  {
    public Teacher(string name, int age, float weight, float height) : base(name, age, weight, height) { }

    public override void Work()
    {
      Console.WriteLine("A teacher is teaching");
      // throw new System.NotImplementedException();
    }
  }

  public class Person
  {
    public void Say()
    {
      Console.WriteLine("Hello");
    }

    public void Say(string words)
    {
      Console.WriteLine(words);
    }
  }

  public class Tile
  {

  }

  public class Motor
  {
    public void Move()
    {

    }
  }

  public class Trap
  {
    public void Damage() { }
  }

  public class MovingTile : Tile
  {
    private readonly Motor _motor;

    public MovingTile(Motor motor)
    {
      _motor = motor;
    }

    public void Move()
    {
      _motor.Move();
    }
  }

  public class TrapTile : Tile
  {
    private readonly Trap _trap;

    public TrapTile(Trap trap)
    {
      _trap = trap;
    }

    public void Damage()
    {
      _trap.Damage()
      }
  }

  public class MovingTrapTile : Tile
  {
    private readonly Motor _motor;
    private readonly Trap _trap;

    public MovingTrapTile(Motor motor, Trap trap)
    {
      _motor = motor;
      _trap = trap;
    }

    public void Move()
    {
      _motor.Move();
    }

    public void Damage()
    {
      _trap.Damage()
      }
  }

  public static class Solution
  {

    public static void Main()
    {

      Mailman mailman = new Mailman("Thomas", 29, 78.5f, 190.11f);
      Teacher teacher = new Teacher("Gareth", 35, 100.5f. 186.49f);

      Human[] humans = { mailman, teacher }

      foreach (var human in humans)
      {
        // using to string methodss
        Console.WriteLine(human);
        human.Work();
      }
    }


  }
}