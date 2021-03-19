using System;

namespace exercise_29
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
        if (firstNumber>secondNumber)
            {
                Console.WriteLine("The larger number is "+firstNumber+"!");
            }
        else if (secondNumber>firstNumber)
            {
                Console.WriteLine("The larger number is "+secondNumber+"!");
            }
        else if (secondNumber==firstNumber)
            {
                Console.WriteLine("They are equal!");
            }
    }
  }
}
