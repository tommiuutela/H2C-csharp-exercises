using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[5];
            while (i < 5)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 10)
                {
                    array[i] = input;

                }
                i = i + 1;

            }
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
        }
    }
}
