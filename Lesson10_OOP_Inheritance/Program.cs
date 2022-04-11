using System;
using Models;

namespace Lesson10_OOP_Inheritance
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var catCount = 2;
            for (int i = 0; i < catCount; i++)
            {
                var eyeColor = GetRandomNumber(0, 14);
                var catColor = GetRandomNumber(0, 14);
                var cat = new Cat("Vaska " + i, '0', eyeColor, catColor);
                cat.Render();
            }

            var dogCount = 2;
            for (int i = 0; i < dogCount; i++)
            {
                var eyeColor = GetRandomNumber(0, 14);
                var catColor = GetRandomNumber(0, 14);
                var dog = new Dog("Sharik " + i, '0', eyeColor, catColor);
                dog.Render();
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

