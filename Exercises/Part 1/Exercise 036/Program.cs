using System;

namespace exercise_36
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
                if (intInput==0)
                    break;
                if (intInput<0)
                    Console.WriteLine("That is negative");
                if (intInput>0)
                    Console.WriteLine(intInput * intInput);
            }
    }
  }
}
