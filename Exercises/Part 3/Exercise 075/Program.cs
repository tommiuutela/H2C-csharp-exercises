﻿using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {


        List<int> numbers = new List<int>();
        numbers.Add(3);
        numbers.Add(2);
        numbers.Add(6);
        numbers.Add(-1);
        numbers.Add(5);
        numbers.Add(1);

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);
      
      Console.WriteLine("The numbers in the range [3, 10]");
      PrintNumbersInRange(numbers, 3, 10);
      
      Console.ReadLine();

    }

        public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
        {
            for(int i = 0; i < numbers.Count; i++) {
            int number = numbers[i];
            if (number >= lowerLimit ) {
                if (number <= upperLimit)
	                {
                     Console.WriteLine(number);
	                }
            }


        }

    }
  }
}

