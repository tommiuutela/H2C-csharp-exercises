﻿using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a number!");
      string userinput = Console.ReadLine();
      int intValue = Convert.ToInt32(userinput);
      Console.WriteLine("You gave "+intValue);
        
    }
  }
}
