using System;

namespace Chapter02.Exercises.Exercise2_02
{

  public class Circle
  {
    private readonly double _radius;

    public Circle(double radius)
    {
      this._radius = radius;
    }

    public double Area
    {
      get { return Math.PI * this._radius * this._radius; }
    }
  }

}