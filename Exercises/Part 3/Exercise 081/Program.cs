﻿using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] array = {5, 1, 3, 4, 2};
       PrintNeatly(array);
       Console.ReadLine();
    }

    public static void PrintNeatly(int[] array)
    {
            for (int i = 0; i < array.Length-1; i++)
			{
                Console.Write(array[i] + ", ");
			}
            Console.Write(array[array.Length-1]);

    }
  }
}

