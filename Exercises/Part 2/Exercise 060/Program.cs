using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
        PrintStars(5);
        PrintStars(3);
        PrintStars(9);
        Console.WriteLine();
        PrintSquare(4);
        PrintRectangle(17,3);
        Console.WriteLine();
        PrintTriangle(4);
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
      Console.WriteLine();
    }

    public static void PrintSquare(int size)
    {
       int i = 0;
      while (i<size)
	{
        i++;
        PrintStars(4);
	}
      Console.WriteLine();

     

    }

    public static void PrintRectangle(int width, int height)
    {
      int i = 0;
      while (i<height)
	{
        i++;
        PrintStars(width);
	}


    }

    public static void PrintTriangle(int size)
    {
      int i = 0;
      int stars = 0;
      while (i<size)
	{
        stars++;
        i++;
        PrintStars(stars);
	}

    }
  }
}
