using System;

namespace Lesson8_Practics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter cat eye shape : ");
            var catEye = Console.ReadKey().KeyChar;
            string padding = "\t\t\t\t\t\t\t";

            var lines = 14;
            for(int i = 0; i < lines; i++)
            {
                Console.WriteLine("");
            }

            Console.WriteLine(@$"{padding} /\_/\");
            Console.WriteLine($"{padding}( {catEye}.{catEye} )");
            Console.WriteLine($"{padding} > ^ <");
            Console.ReadLine();
        }
    }

}
