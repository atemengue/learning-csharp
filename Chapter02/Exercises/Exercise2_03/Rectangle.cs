using System;
using Chapter02.Exercises.Interaces;

namespace Chapter02.Exercises.Exercice2_03
{

  public class Rectangle : IShape
  {
    private readonly double _width;
    private readonly double _height;

    public double Area
    {
      get
      {
        return this._height * this._width;
      }
    }

    public Rectangle(double width, double height)
    {
      this._height = height;
      this._width = width;
    }
  }

}