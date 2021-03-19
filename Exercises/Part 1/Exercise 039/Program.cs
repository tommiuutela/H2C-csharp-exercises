using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
                 int sum = 0;

      while (true)
            {
                Console.WriteLine("Give a number:");
                int intInput = Convert.ToInt32(Console.ReadLine());
                if (intInput==0)
                    {
                    break;
                }
                if (intInput<0)
                    {
                    sum = sum + intInput;
                }
                if (intInput>0)
                    {
                    sum = sum + intInput;    
                }
                    
            }
      Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
