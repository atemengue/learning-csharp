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

  public class Human
  {
    public string Name { get; }
    public int Age { get; }
    public float Weight { get; }
    public float Height { get; }

    public Human(string name, int age, float weight, float height)
    {
      this.Name = name;
      this.Age = age;
      this.Height = height;
      this.Weight = weight;
    }

    public class Mailman : Human
    {
      public Mailman(string name, int age, float weight, float height) : base(name, age, weight, height) { }

      public void DeliverMail(Mail mail)
      {

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
}