// Namespace declaration
using System;
using csTut = csharp_station.aliasTutorial.exampleClass; // Alias

class AliasDirective
{
    public static void Main()
    {
        csTut.exampleFunction();
        exampleFunction();
    }

    // Potentially ambiguous method.
    static void exampleFunction()
    {
        Console.WriteLine("Not a member of csharp_station.aliasTutorial.exampleClass");
    }
}

// C# Station aliasTutorial Namespace
namespace csharp_station.aliasTutorial
{
    class exampleClass
    {
        public static void exampleFunction()
        {
            Console.WriteLine("Is a member of csharp_station.aliasTutorial.exampleClass");
        }
    }
}
