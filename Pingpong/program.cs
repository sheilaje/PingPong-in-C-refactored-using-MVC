using  System;

namespace  Pingpong
{
  public class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Enter the number: ");
      string input = Console.ReadLine();
      int userInput = int.Parse(input);

      for (int i=1; i<= userInput; i++)
      {
        string x = Pingpong.PingpongCheck(i);
        Console.WriteLine(x);
      }
    }
  }
}
