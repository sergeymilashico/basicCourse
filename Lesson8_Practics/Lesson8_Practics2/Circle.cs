namespace Lesson8_Practics
{
    internal struct Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        internal double GetArea()
        {
            return Math.Pow(this.radius, 2) * Math.PI;
        }
    }
}