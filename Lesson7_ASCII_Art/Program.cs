using System;

namespace Lesson7_ASCII_IN_CSHARP
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var catEye = "x";
            var paddingLesft = "\t\t";
            Console.WriteLine(paddingLesft + @"  /\_/\");
            Console.WriteLine(paddingLesft + $" ( {catEye}.{catEye} )");
            Console.WriteLine(paddingLesft + "  > ^ <");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

