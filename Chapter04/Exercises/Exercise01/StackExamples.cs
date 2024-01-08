using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter04.Exercises.Exercise01.StackExample
{

  public class UndoStack
  {
    private readonly Stack<Action> _undoStack = new Stack<Action>();

    public void Do(Action action)
    {
      _undoStack.Push(action);
    }

    public void Undo()
    {
      if (_undoStack.Count > 0)
      {
        var undo = _undoStack.Pop();
        undo?.Invoke();
      }
    }
  }

  public class TextEditor
  {
    private readonly UndoStack _undoStack;

    public TextEditor(UndoStack undoStack)
    {
      _undoStack = undoStack;
    }

    public string Text { get; private set; }

    public void EditText(string newText)
    {
      var previousText = Text;
      _undoStack.Do(() =>
      {
        Text = previousText;
        Console.Write($"Undo:'{newText}'".PadRight(40));
        Console.WriteLine($"Text='{Text}'");
      });

      Text += newText;
      Console.Write($"Edit:'{newText}'".PadRight(40));
      Console.WriteLine($"Text='{Text}'");

    }
  }
}