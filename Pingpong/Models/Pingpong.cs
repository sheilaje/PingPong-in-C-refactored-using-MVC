namespace Pingpong
{
  public class Pingpong
  {
    public bool PingpongCheck(int number)
    {
      if (number % 3 == 0 && number % 5 != 0)
      {
        return false;
      }else
      if (number % 5 == 0 && number % 3 != 0)
      {
        return false;
      }
      else if (number % 3 == 0 && number % 5 == 0)
      {
        return false;
      }
      else
      {
        return false;
      }
    }
  }
}
