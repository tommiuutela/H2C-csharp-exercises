using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
     string input= Console.ReadLine();
     int oldest = 0; 
     int longest = 0;
     string longestName = string.Empty;

            while (input!="")
	{
     string[] ageinput = input.Split(',');
     int birthYear = Convert.ToInt32(ageinput[1]);
     input = Console.ReadLine();
     int length = ageinput[0].Length;
     if (2020-birthYear>oldest)
	 {
     oldest=2020-birthYear;
	 }
     if (length>longest)
	 {
     longest = length;
     longestName=ageinput[0];
	 }
     Array.Clear(ageinput, 0, ageinput.Length);
	}
            Console.WriteLine("Longest name: " + longestName);
            Console.WriteLine("Highest age: " + oldest);
            Console.ReadLine();
    }
  }
}



