using System;

namespace VariablesExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("The variable x contains " + x);
            x = 5;
            Console.WriteLine("The variable x contains " + x);
            int y = 2;
            Console.WriteLine("The variable y contains " + y);
            float z = 2.4f;
            Console.WriteLine("The variable z contains " + z);
            Console.WriteLine("The integer cast of z is " + (int)z);
            Console.WriteLine("Hit any key to end...");
            Console.ReadKey();
        }
    }
}
