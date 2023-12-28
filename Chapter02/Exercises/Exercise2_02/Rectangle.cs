using System;

namespace Chapter02.Exercises.Exercise2_02
{
  public class Rectangle
  {
    private readonly double _width;
    private readonly double _height;

    public double Area
    {
      get
      {
        return this._width * this._height;
      }
    }

    public Rectangle(double width, double height)
    {
      this._width = width;
      this._height = height;
    }
  }
}
