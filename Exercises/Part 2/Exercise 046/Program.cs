using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

     int input = Convert.ToInt32(Console.ReadLine());
     int count = input;
                while (count<101)
            {
                Console.WriteLine(count);
                count = count+1;
            }

    }
  }
}
