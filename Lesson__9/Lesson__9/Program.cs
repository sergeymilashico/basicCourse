using System;

namespace Lesson9
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide symbol for cat eye : ");
            var catEye = Console.ReadKey().KeyChar;
            var padding = "\t\t\t\t\t\t\t";
            int lines = 14;
            for(int i = 0; i < lines; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine($@"{padding}   /\_/\");
            Console.WriteLine($"{padding}  ( {catEye}.{catEye} )");
            Console.WriteLine($"{padding}   > ^ <");
            Console.ReadLine();
        }
    }
}
