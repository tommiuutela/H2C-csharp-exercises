using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      Account heikkisAccount = new Account("Heikki's account", 1000.00);
      Account PersonalAccount = new Account("Heikki's  personal account", 0.00);

            heikkisAccount.Withdrawal(100);
            PersonalAccount.Deposit(100);
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(PersonalAccount);
            Console.ReadLine();


    }
  }
}



