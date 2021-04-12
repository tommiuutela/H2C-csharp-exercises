using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give numbers:");
            int sum = 0;
            int count = 0;
            int even = 0;
            int odd = 0;
       while (true)
        {
                
          int input = Convert.ToInt32(Console.ReadLine());
          if  (input==-1)
                {
                    Console.WriteLine("Thx! Bye!");
                    break;
                }
          if (input%2==0)
                {
                 even = even + 1;
                }
          else
                {
                  odd = odd + 1;
                }
          count = count+1;
          sum = sum+input;                                      
        }
       Console.WriteLine("Sum: "+sum);
       Console.WriteLine("Numbers: " + count);
       Console.WriteLine("Average: " + ((double)sum)/count);
       Console.WriteLine("Even:" + even);
       Console.WriteLine("Odd:" + odd);
       Console.ReadLine();
    }
  }
}
