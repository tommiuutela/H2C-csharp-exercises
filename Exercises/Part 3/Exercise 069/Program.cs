using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }



      Console.WriteLine("From Where?");
            int start = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where to?");
            int stop = Convert.ToInt32(Console.ReadLine());

      while (start<=stop)
	 {
     Console.WriteLine(list[start]);
                start++;
	 }
            Console.ReadLine();
     }
  }
}
