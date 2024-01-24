using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Exercises
{

  public class ListElement
  {

    public string Noeud = string.Empty;
    public ListElement Next;

    public ListElement(string name)
    {
      Noeud = name;
    }
  }

  public class SingleLinkedList
  {

    public ListElement Head { get; set; }

    public SingleLinkedList()
    {
      Head = null;
      Console.WriteLine("Creation du liste vide");
    }

    public SingleLinkedList(ListElement anchor)
    {
      Head = anchor;
    }

    public void Add(string name)
    {
      ListElement newElement = new ListElement(name);

      if (Head == null)
      {
        Head = newElement;
      }
      else
      {
        ListElement cursor = Head;
        while (cursor.Next != null)
        {
          cursor = cursor.Next;
        }
        cursor.Next = newElement;
      }
    }

    public void Add(ListElement newElement)
    {
      if (Head == null)
      {
        Head = newElement;
      }
      else
      {
        ListElement cursor = Head;
        while (cursor.Next != null)
        {
          cursor = cursor.Next;
        }
        cursor.Next = newElement;
      }
    }

    public void InsertAfter(ListElement element, ListElement newElement)
    {
      ListElement cursor = Head;
      while (cursor.Next !== null)
      {
        if (cursor.Noeud == element.Noeud)
          break;
        else
          cursor = cursor.Next;
      }


      ListElement shiftElement = cursor.Next;
      element.Next = newElement;
      newElement.Next = shiftElement;

    }
  }

  public class Program
  {

    public static void Main()
    {





    }
  }

}