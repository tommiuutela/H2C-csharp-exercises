using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Give the first number!");
       string firstInput = Console.ReadLine();
     Console.WriteLine("Give the second number!");
       string secondInput = Console.ReadLine();
     Console.WriteLine("Give the third number!");
       string thirdInput = Console.ReadLine();
     int firstNumber = Convert.ToInt32(firstInput);
     int secondNumber = Convert.ToInt32(secondInput);
     int thirdNumber = Convert.ToInt32(thirdInput);
     Console.WriteLine("The average is "+((double)firstNumber + secondNumber + thirdNumber) / 3);       
    }
  }
}
