using System;

namespace exercise_50
{
  class Program
  {
      public static void Main(string[] args)
    {
      Console.WriteLine("How many times?");
      int repetition = Convert.ToInt32(Console.ReadLine());
      int count = 0;
            while (count<repetition)
            {
               PrintPhrase();
               count = count + 1;
            } 
    }

    public static void PrintPhrase() {
     Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
