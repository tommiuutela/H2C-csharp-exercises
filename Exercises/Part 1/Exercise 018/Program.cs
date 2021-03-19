using System;

namespace exercise_18
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
     int sum = firstNumber + secondNumber + thirdNumber;
     Console.WriteLine("The sum is "+sum);

    }
  }
}
