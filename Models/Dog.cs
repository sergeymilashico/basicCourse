using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Animal
    {

        public Dog(string catName, char catEye, int catEyeColor, int catColor) : base(catName, catEye, catEyeColor, catColor)
        {
        }

        public override void Render()
        {
            var lines = 3;
            for (var i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }
            var paddingLesft = "\t\t";

            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(paddingLesft + @"  /^ ^\");
            Console.Write(paddingLesft + @" / ");
            Console.ForegroundColor = (ConsoleColor)eyeColor;
            Console.Write($"{eye} {eye}");
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(" \\");

            Console.WriteLine(paddingLesft + @" V\ Y /V");
            Console.WriteLine(paddingLesft + @"  / - \");
            Console.WriteLine(paddingLesft + @" /    |");
            Console.WriteLine(paddingLesft + @"V__) ||");
            Console.WriteLine(paddingLesft + $"  {name}");
        }
    }
}
