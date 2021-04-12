using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
       string input = Console.ReadLine();
        while (input!="")
	{
        string[] pieces = input.Split(' ');
        Console.WriteLine(pieces[0]);       	
        input = Console.ReadLine();
     }
    }
  }
}



