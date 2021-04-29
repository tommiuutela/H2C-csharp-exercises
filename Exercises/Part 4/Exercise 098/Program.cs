using System;

namespace exercise_98
{
  class Program
  {
    public static void Main(string[] args)
    {
      Product CocaCola = new Product("CocaCola", 1.60, 600);
      CocaCola.PrintProduct();
            Console.ReadLine();
      

    }
  }
    class Product
	{
        private double price;
        private int quantiny;
        private string name;

        public Product(string name, double price, int quantiny)
        { 
        this.name=name;
        this.price=price;
        this.quantiny=quantiny;       
        }
        
        public void PrintProduct()
        {
        Console.WriteLine(this.name + ": price " + this.price + ": " + this.quantiny + " pcs");

        }

	}
}



