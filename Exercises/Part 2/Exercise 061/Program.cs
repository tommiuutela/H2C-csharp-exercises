using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            PrintRightTriangle(4);
            ChristmasTree(40);
            Console.ReadLine();



    }

    public static void PrintStars(int number)
    {
      int i = 0;
      while (i<number)
	{
       Console.Write("*");
       i++;
	}

    }

    public static void PrintSpaces(int number)
    {
                int i = 0;
      while (i<number)
	{
       Console.Write(" ");
       i++;
	}
    }

    public static void PrintRightTriangle(int size)
    {
     int i = 1;
     while (size>0)
	{
     PrintSpaces(size-1);
     PrintStars(i);
     i++;
     size--;
     Console.WriteLine();
	}

    }

    public static void ChristmasTree(int height)
    {
             int i = 1;
     while (height>0)
	{
     PrintSpaces(height-1);
     PrintStars(i);
     i=i+2;
     height--;
     Console.WriteLine();
	}
     PrintSpaces(i/2-2);
     PrintStars(3);
     Console.WriteLine();
     PrintSpaces(i/2-2);
     PrintStars(3);

    }
  }
}
