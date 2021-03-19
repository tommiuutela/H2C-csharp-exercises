using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string numinput = Console.ReadLine();
      int num = Convert.ToInt32(numinput);
            if (num%2==0)
            {
                Console.WriteLine("It is even.");
            }
            else
            {
                Console.WriteLine("It is odd.");
            }
            Console.ReadLine();

    }
  }
}
