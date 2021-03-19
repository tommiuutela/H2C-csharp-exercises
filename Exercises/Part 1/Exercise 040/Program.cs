using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
           int numcount = 0;
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
                    numcount = numcount + 1;
                }
                if (intInput>0)
                    {
                    sum = sum + intInput; 
                    numcount = numcount + 1;
                }      
            }
      Console.WriteLine("Total amount of numbers: " + numcount +
          "\nTotal sum of numbers: " + sum);
    }
  }
}
