using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
        
        Console.WriteLine("Search for?");
        string askedString = Console.ReadLine();
        int notfound = 1;

          for(int i = 0; i < list.Count; i++) {
            if (askedString == list[i]) {
               Console.WriteLine(askedString + " was found!");
               notfound = 0;
                        break;
            }
            }
          if (notfound == 1)
	            {
                Console.WriteLine(askedString + " was not found");
	            }
          Console.ReadLine();

      
    }
  }
}

