using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {  
     string input= Console.ReadLine();
     int oldest = 0;

            while (input!="")
	{   
     string[] ageinput = input.Split(',');
     int age = Convert.ToInt32(ageinput[1]);
     Array.Clear(ageinput, 0, ageinput.Length);
     input = Console.ReadLine();
                if (age>oldest)
	{
     oldest = age;
	}
	}
            Console.WriteLine("Age of the oldest: " + oldest);
            Console.ReadLine();

    }
  }
}



