﻿using System;

namespace Chapter03.Exercise01
{

  public delegate bool DateValidationHandler(DateTime dateTime);

  public class Order
  {
    private readonly DateValidationHandler _orderDateValidator;
    private readonly DateValidationHandler _deliveryDateValidator;
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }




    public Order(DateValidationHandler orderDateValidator, DateValidationHandler deliveryDateValidator)
    {
      _orderDateValidator = orderDateValidator;
      _deliveryDateValidator = deliveryDateValidator;
    }

    public bool IsValid() => _orderDateValidator(OrderDate) && _deliveryDateValidator(DeliveryDate);
  }

  public static class Program
  {

    private static bool IsWeekendDate(DateTime date)
    {
      Console.WriteLine("Called IsWeekendDate");
      return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }

    private static bool IsPastDate(DateTime date)
    {
      Console.WriteLine("Called IsPastDate");
      return date < DateTime.Today;
    }

    public static void Main()
    {
      var orderValidator = new DateValidationHandler(IsPastDate);
      var deliveryValidator = new DateValidationHandler(IsWeekendDate);

      var order = new Order(orderValidator, deliveryValidator)
      {
        OrderDate = DateTime.Today.AddDays(-10),
        DeliveryDate = new DateTime(2023, 12, 31)
      };

      Console.WriteLine($"Ordered: {order.OrderDate:dd-MMM-yy}");
      Console.WriteLine($"Delivered: {order.DeliveryDate:dd-MMM-yy}");
      Console.WriteLine($"IsValid: {order.IsValid()}");
    }
  }
}