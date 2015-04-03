using System;

// C# Station usingTutorial Namespace
namespace NamespaceInMultipleFiles
{
    class ClassInFile2
    {
        public static void FuncInFile2()
        {
            Console.WriteLine("Function in File2, ClassInFile2.");
        }
    }

    public partial class PartialClass
    {
        public static void FuncInFile2()
        {
            Console.WriteLine("Function in File2, PartialClass.");
        }
    }
}
