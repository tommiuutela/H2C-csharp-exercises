﻿using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> strings = new List<string>();

        strings.Add("First");
        strings.Add("Second");
        strings.Add("Third");

            strings.ForEach(Console.WriteLine);
            RemoveLast(strings);
            RemoveLast(strings);
            strings.ForEach(Console.WriteLine);
            Console.ReadLine();

    }
        public static void RemoveLast(List<string> strings)
        {           
            strings.RemoveAt(strings.Count-1);
        }
   }

  }



