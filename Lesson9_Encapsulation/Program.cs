using System;
using Models;

namespace Lesson9_Encapsulation
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var catCount = 5;
            for(var i = 0; i < catCount; i++)
            {
                var eyeColor = GetRandomNumber(0, 14);
                var catColor = GetRandomNumber(0, 14);
                var cat = new Cat("Vaska " + i, '0', eyeColor, catColor);
                if (i == 3) cat.Name = "Marusya ";
                cat.Render();
                Console.WriteLine(cat.Name);
            }

            Console.ReadLine(); 
        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
    }
}

