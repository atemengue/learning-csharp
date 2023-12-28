using Chapter02.Exercises.Interaces;

namespace Chapter02.Exercises.Exercice2_03
{

  public class Circle : IShape
  {

    private readonly double _radius;

    public Circle(double radius)
    {
      _radius = radius;
    }

    public double Area
    {
      get { return Math.PI * this._radius * this._radius; }
    }
  }

}