using System;

namespace Pingpong.Models
{
  public class PingPongGenerator
  {
    private int _number;

    public int GetInput()
    {
      return _number;
    }

    public void SetInput(int newNumber)
    {
      _number = newNumber;
    }

    public string PingpongCheck()
    {
      for (int i = 1; i <= _number; i++)
      {
        if (i % 3 == 0 && i % 5 != 0)
        {
          return "ping";
        }
        else if (i % 5 == 0 && i % 3 != 0)
        {
          return "pong";
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
          return "pingpong";
        }
        else
        {
          return i.ToString();
        }
      }
    }
    
  }
}
