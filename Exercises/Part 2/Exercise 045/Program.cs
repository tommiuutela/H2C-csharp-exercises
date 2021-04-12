using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      int input = Convert.ToInt32(Console.ReadLine());
      int count = 0;
            while (count<input+1)
            {
                Console.WriteLine(count);
                count = count+1;
            }
    }
  }
}
