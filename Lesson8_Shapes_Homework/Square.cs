namespace Lesson8_Shapes_Homework
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
            return Math.Pow(side, 2);
        }
    }
}