// Namespace declaration
using System;
using NamespaceInMultipleFiles;

// Program start class
class NamespaceDemo
{
    // Main begins program execution.
    public static void Main()
    {
        // Call namespace member
        ClassInFile1.FuncInFile1();
        ClassInFile2.FuncInFile2();
        PartialClass.FuncInFile1();
        PartialClass.FuncInFile2();
    }
}

// C# Station usingTutorial Namespace
namespace NamespaceInMultipleFiles
{
    class ClassInFile1
    {
        public static void FuncInFile1()
        {
            Console.WriteLine("Function in File1, ClassInFile1.");
        }
    }

    public partial class PartialClass
    {
        public static void FuncInFile1()
        {
            Console.WriteLine("Function in File1, PartialClass.");
        }
    }
}
