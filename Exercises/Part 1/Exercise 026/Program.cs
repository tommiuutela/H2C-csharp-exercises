using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give your age:");
      string input = Console.ReadLine();
      int age = Convert.ToInt32(input);
            if (age<1900)
            {
                Console.WriteLine("you're old");
            }

    }
  }
}
