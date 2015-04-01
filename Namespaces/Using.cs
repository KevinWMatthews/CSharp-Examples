// Namespace declaration
using System;
using csharp_station.usingTutorial;

// Program start class
class UsingDirective
{
    // Main begins program execution.
    public static void Main()
    {
        // Call namespace member
        exampleClass.exampleFunction();
    }
}

// C# Station usingTutorial Namespace
namespace csharp_station.usingTutorial
{
    class exampleClass
    {
        public static void exampleFunction()
        {
            Console.WriteLine("Example of a using directive.");
        }
    }
}
