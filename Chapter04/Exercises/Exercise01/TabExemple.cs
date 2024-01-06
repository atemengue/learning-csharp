using System;
using System.Collections;
using System.Collections.Generic;
using Chapter04.Exercises.Exercis01;

namespace Chapter04.Exercises.Exercis01
{

  public class Tab
  {
    public Tab() { }
    public string Url { get; set; }
    public override string ToString() => Url;
    public Tab(string url) => (Url) = url;
  }


  public class TabController : IEnumerable<Tab>
  {
    private readonly List<Tab> _tabs = new();

    public Tab OpenNew(string url)
    {
      var tab = new Tab(url);
      _tabs.Add(tab);
      Console.WriteLine($"OpenNew {tab}");
      return tab;
    }

    public void Close(Tab tab)
    {
      if (_tabs.Remove(tab))
      {
        Console.WriteLine($"Removed {tab}");
      }
    }

    public void MoveToStart(Tab tab)
    {
      if (_tabs.Remove(tab))
      {
        _tabs.Insert(0, tab);
        Console.WriteLine($"Moved tab to start");
      }
    }

    public void MoveToEnd(Tab tab)
    {
      if (_tabs.Remove(tab))
      {
        _tabs.Add(tab);
        Console.WriteLine($"Moved tab to end indexe of tab is {_tabs.IndexOf(tab)}");
      }
    }

    // interface implementation the interface IEnumerable
    public IEnumerator<Tab> GetEnumerator() => _tabs.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => _tabs.GetEnumerator();
  }



}