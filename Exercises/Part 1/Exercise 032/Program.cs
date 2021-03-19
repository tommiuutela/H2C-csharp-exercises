using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Speak, friend, and enter!");
      string word = Console.ReadLine();
      string answer = "Mellon";
      if (word==answer)

            {
                Console.WriteLine("Welcome, friend");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");
            }
            Console.ReadLine();

    }
  }
}
