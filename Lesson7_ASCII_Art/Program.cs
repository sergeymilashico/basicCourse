
using System;

namespace Lesson7_ASCII_IN_CSHARP
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int lines = 14;
            for(int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }

            var catEye = "0";
            var paddingLesft = "\t\t\t\t\t\t\t";
            Console.WriteLine(paddingLesft + @"  /\_/\");
            Console.WriteLine(paddingLesft + $" ( {catEye}.{catEye} )");
            Console.WriteLine(paddingLesft + "  > ^ <");
            Console.ReadLine();
        }
    }
}

