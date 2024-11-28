using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which is the best colour? Red or Blue?");
            string colour = Console.ReadLine();

            if(colour == "Blue")
            {
                Console.WriteLine(colour + " is a good choice");
            }
            else if(colour == "Red")
            {
                Console.WriteLine(colour + " is a good choice");
            }
        }
    }
}
