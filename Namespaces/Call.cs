// Namespace declaration for using Console.WriteLine
using System;

// The C# Station namespace, which is the name of this tutorial
namespace csharp_station
{
    // A nested namespace
    namespace calledNamespace
    {
        class exampleClass1
        {
            // Leave argument list blank if no arguments are expected
            public static void exampleMethod()
            {
                Console.WriteLine("First example of one namespace calling the member of another namespace");
            }
        }
    }

    // Program start class
    class callingNamespace
    {
        // Main begins program execution.
        public static void Main()
        {
            // Call a method from a different namespace using a fully qualified name
            calledNamespace.exampleClass1.exampleMethod();
            calledNamespace.exampleClass2.exampleMethod();
        }
    }
}

// Extend the namespace, this time not nested
namespace csharp_station.calledNamespace
{
    class exampleClass2
    {
        public static void exampleMethod()
        {
            Console.WriteLine("Second example of one namespace calling the member of another namespace");
        }
    }
}
