using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Please give 2 numbers:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input1==input2)
            {
                Console.WriteLine(input1+" is equal to "+input2);
            }
            else if (input1>input2)
            {
                Console.WriteLine(input1+" is greater than "+input2);
            }
            else
            {
               Console.WriteLine(input1+" is less than "+input2);
            }
           


    }
  }
}
