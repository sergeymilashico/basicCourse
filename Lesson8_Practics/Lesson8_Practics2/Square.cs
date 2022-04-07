namespace Lesson8_Practics
{
    internal class Square
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        internal double GetArea()
        {
            return Math.Pow(this.side, 2);
        }
    }
}