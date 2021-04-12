using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
     List <string> usernames = new List<string>();
     List <string> passwords = new List<string>();
            usernames.Add("alex");
            passwords.Add("sunshine");
            usernames.Add("emma");
            passwords.Add("haskell");
     Console.WriteLine("Enter username:");
            string usernameInput = Console.ReadLine();
     Console.WriteLine("Enter password:");
            string passwordInput = Console.ReadLine();

            for (int i = 0; i < usernames.Count; i++)
			{
             if (usernameInput==usernames[i])
	            {
                    if (passwordInput==passwords[i])
	                    {
                        Console.WriteLine("You have successfully logged in!");
                        break;
	                    }
                    else
	                    {
                        Console.WriteLine("Incorrect username or password!");
                        break;
	                    }
	                    }
                        if (i==usernames.Count-1)
                        {
                        Console.WriteLine("Incorrect username or password!");
                        }                
			}

     Console.ReadLine();

    }
  }
}

