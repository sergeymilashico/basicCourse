using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Animal
    {
        public Cat(string catName, char catEye, int catEyeColor, int catColor) : base(catName, catEye, catEyeColor, catColor)
        {  
        }

        public override void Render()
        {
            int lines = 3;
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }

            var paddingLesft = "\t\t";
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(paddingLesft + @"  /\_/\");
            Console.Write(paddingLesft + " ( ");
            Console.ForegroundColor = (ConsoleColor)eyeColor;
            Console.Write($"{ eye}.{eye}");
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(" )");
            Console.WriteLine(paddingLesft + "  > ^ <");
            Console.WriteLine(paddingLesft + $"  {name}");
        }
    }
}
