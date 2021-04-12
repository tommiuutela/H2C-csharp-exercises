using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Where to?");
            int to = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
            int from = Convert.ToInt32(Console.ReadLine());
         int count = from;
          while (count<to+1)
            {
                Console.WriteLine(count);
                count = count + 1;
            }
    }
  }
}
