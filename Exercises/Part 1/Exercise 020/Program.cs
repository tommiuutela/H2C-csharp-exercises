﻿using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Give the first number!");
       string firstInput = Console.ReadLine();
     Console.WriteLine("Give the second number!");
       string secondInput = Console.ReadLine();
     int firstNumber = Convert.ToInt32(firstInput);
     int secondNumber = Convert.ToInt32(secondInput);
     int multiplied = firstNumber * secondNumber;
     Console.WriteLine(firstNumber+" * "+secondNumber+" = "+multiplied);

    }
  }
}
