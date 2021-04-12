using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
     string input= Console.ReadLine();
     int oldest = 0;
     string oldestName = string.Empty;   

            while (input!="")
	{
     string[] ageinput = input.Split(',');
     int age = Convert.ToInt32(ageinput[1]);
     input = Console.ReadLine();
                if (age>oldest)
	{
       oldest=age;
       oldestName=ageinput[0];
	}
    Array.Clear(ageinput, 0, ageinput.Length);
	}
            Console.WriteLine("Name of the oldest: " + oldestName);
            Console.ReadLine();
    }
  }
}



