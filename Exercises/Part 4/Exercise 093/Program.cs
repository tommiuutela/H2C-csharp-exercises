using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {

            Account aurasAccount = new Account("Auras account", 100 );
            aurasAccount.Deposit(20);

            Console.WriteLine(aurasAccount);
            Console.ReadLine();
    }
  }
}



