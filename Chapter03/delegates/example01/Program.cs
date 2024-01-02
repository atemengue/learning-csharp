using System;

public static class Solution
{

  public class Point
  {

    private double X { get; set; }
    private double Y { get; set; }
  }

  public interface ITransform
  {
    Point Move(double height, double width);
  }

  public class RotateTransform : ITransform
  {
    public Point Move(double height, double width)
    {
      return new Point();
    }

  }

  public class ZoomTransform : ITransform
  {
    public Point Move(double height, double width)
    {
      return new Point;
    }
  }


  public class Transform
  {
    public void Transform()
    {
      var rotatePoint = Calculate(new RotateTransform(), 100, 20);
      var zoomPoint = Calculate(new ZoomTransform(), 5, 5);
    }

    public void Calculate(ITransform transform, double height, double width)
    {
      var point = transform.Move(height, width);
      return point;
    }
  }

  public static void Main()
  {

    Console.WriteLine("Hello");
  }
}