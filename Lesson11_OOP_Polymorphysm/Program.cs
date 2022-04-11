using System;
using Models;

namespace Lesson11_OOP_Polymorphysm
{
    public static class Program
    {
        const int animalCount = 4;
        
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[animalCount];

            for (int i = 0; i < animalCount; i++)
            {
                var eyeColor = GetRandomNumber(0, 14);
                var catColor = GetRandomNumber(0, 14);
                Animal animal;
                if(i < 2)
                {
                    animal = new Cat("Vaska " + i, '0', eyeColor, catColor);
                }
                else
                {
                    animal = new Dog("Sharik " + i, '0', eyeColor, catColor);
                }
                animals[i] = animal;
            }

            foreach(var animal in animals)
            {
                animal.Render();
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

