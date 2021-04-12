using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      DivisibleByThreeInRange(3, 60);
      Console.ReadLine();

    }

    public static void DivisibleByThreeInRange(int min, int max)
        {

         int count = min;
         while (true)
            {
             if (count<max)
                {
                  count = count+1;                 
                }
             if (count%3==0)
                {
                Console.WriteLine(count);
                }
             if (count==max)
                { 
                break;
                }
            }
        }

  }
}
