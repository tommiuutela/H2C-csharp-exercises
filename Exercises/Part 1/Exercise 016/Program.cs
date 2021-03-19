using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("How many days?");
      string days = Console.ReadLine();
         int daysValue = Convert.ToInt32(days);
      int seconds = daysValue*24*60*60;
      Console.WriteLine(seconds);

    }
  }
}
