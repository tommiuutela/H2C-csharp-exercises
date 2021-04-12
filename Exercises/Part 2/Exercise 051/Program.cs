using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      
      PrintUntilNumber(5);


    }

    public static void PrintUntilNumber(int number) {
     
     int count = 1;
     while (count<number+1)
            { 
            Console.WriteLine(count);
            count = count + 1;
            }
    }

  }
}
