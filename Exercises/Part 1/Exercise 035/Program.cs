using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
       while (true)
            {
            Console.WriteLine("Give a number:");
                string input = Console.ReadLine();
                int intInput = Convert.ToInt32(input);
                if (intInput==42)
                    break;
            }

    }
  }
}
