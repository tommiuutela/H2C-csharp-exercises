using System;

namespace exercise_100
{
  class Program
  {
    public static void Main(string[] args)
    {
    Debt mortgage = new Debt(120000.0, 1.01);
    mortgage.PrintBalance();

    mortgage.WaitOneYear();
    mortgage.PrintBalance();

    // Wait 20 years
    int years = 0;
    while (years < 20)
  {
    mortgage.WaitOneYear();
    years = years + 1;
  }

    mortgage.PrintBalance();
            Console.ReadLine();

    }
  }
    class Debt
	{
        private double Balance;
        private double Rate;
        

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.Balance = initialBalance;
            this.Rate = initialInterestRate;
        }

        public void PrintBalance()
        {
         Console.WriteLine(this.Balance);
        }

        public void WaitOneYear()
        {
          this.Balance=this.Balance * this.Rate;
        }
    }
  }





