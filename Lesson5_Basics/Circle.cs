using System;

namespace Lesson5_Basics
{
    public struct Circle
    {
        public int Radius { get; private set; }

        public int X { get; private set; }

        public int Y { get; private set; }

        //const double PI = 3.14;

        public Circle(int radius, int x, int y)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double GetArea()
        {
            //return PI * Radius;

            //Use Math project
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}