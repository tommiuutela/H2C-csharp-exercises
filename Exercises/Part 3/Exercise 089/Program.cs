using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        while (input!="")
	{
        string[] pieces = input.Split(' ');
        Console.WriteLine(pieces[pieces.Length-1]);
        input = Console.ReadLine();
     }
    }
  }
}



