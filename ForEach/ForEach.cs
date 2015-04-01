using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibArray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            //foreach (<type> <iteration variable> in <list>)
            //This works provided <list> implements Systems.Collections.IEnumerable
            foreach (int element in fibArray)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
