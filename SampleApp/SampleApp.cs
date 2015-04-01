using System;

namespace SimpleApplication     //Declare our own namespace to disambiguate identifiers
{
    public class Program
    {
        public static void Main ()  //Entry point of the program
        {
            string firstname, lastname;
            Console.WriteLine("Please enter your first name:");
            firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            lastname = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}!", firstname, lastname);
            Console.ReadLine();
        }
    }
}
