using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter new email address");
            string email = Console.ReadLine();

            if(email.Equals("4123601@myuwc.ac.za", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Sorry " + email + " is being used by another user");
            }
            else
            {
                Console.WriteLine("Yes " + email + " is available for you");
            }
        }
    }
}
