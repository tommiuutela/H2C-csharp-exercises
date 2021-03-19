using System;

namespace exercise_23
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
     Console.WriteLine(firstNumber+" + "+secondNumber+" = "+(firstNumber + secondNumber)+"\n"
         +firstNumber+" - "+secondNumber+" = "+(firstNumber - secondNumber)+"\n"
         +firstNumber+" * "+secondNumber+" = "+(firstNumber * secondNumber)+"\n"
         +firstNumber+" / "+secondNumber+" = "+((double)firstNumber / secondNumber));

    }
  }
}
