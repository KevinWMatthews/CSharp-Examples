using System;

namespace UserInput
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Please enter a value for the radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("The area of a circle with radius " + radius + " is " + area);
        Console.WriteLine("Hit any key to end...");
        Console.ReadKey();
    }
  }
}
