using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Give a string:");
       string stringUserinput = Console.ReadLine();
     Console.WriteLine("Give an integer");
       string integerUserinput = Console.ReadLine();
            int intValue = Convert.ToInt32(integerUserinput);
     Console.WriteLine("Give a double:");
       string doubleUserinput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(doubleUserinput);
     Console.WriteLine("Give a boolean:");
       string truth = Console.ReadLine();
            bool booleanValue = System.Convert.ToBoolean(truth);

     Console.WriteLine("Your string is: "+stringUserinput+"\nyour integer: "+intValue+
         "\nYour double: "+doubleValue+"\nYour boolean: "+booleanValue);
    Console.ReadLine();
     
    }
  }
}
