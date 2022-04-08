//namespace . For logical separation of classes

namespace Lesson5_Basics
{
    class Program
    {
        //Program to show logical operations, primitive data types
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            IfElseRun();
            SwitchRun();
        }

        private static char ProvideUserInput()
        {
            Console.WriteLine("PLease enter type of shape. Type C for circle,  S for square");
            //Char - contain one letter. Primitive data type
            //access 1st element of char array here
            char figure = Console.ReadLine()[0];
            return figure;
        }

        //method introduction
        private static void IfElseRun()
        {
            char figure = ProvideUserInput();

            //Casting here. Logical operators OR
            //result of if statement is boolean type
            if (figure == 'C' || figure == 'S')
            {
                if (figure == 'C')
                {
                    //Creating struct here
                    Circle circle = new Circle(3, 0, 0);
                    Console.WriteLine("Circle area = " + circle.GetArea());
                }
                else if (figure == 'S')
                {
                    //Creating struct here
                    Square square = new Square(4, 0, 0);
                    Console.WriteLine("Square area = " + square.GetArea());
                }
            }
            //use of if .. else
            else
            {
                Console.WriteLine("ERROR. Type C for circle, S for square");
            }

            int[] intValues = new int[5];
            var circles = new Circle[5];
        }

        private static void SwitchRun()
        {
            char figure = ProvideUserInput();

            //Casting here. Logical operators OR
            //result of if statement is boolean type
            switch (figure)
            {
                case 'C':
                    //Creating struct here
                    Circle circle = new Circle(3, 0, 0);
                    Console.WriteLine("Circle area = " + circle.GetArea());
                    break;
                case 'S':
                    // code block
                    Square square = new Square(4, 0, 0);
                    Console.WriteLine("Square area = " + square.GetArea());
                    break;
                default:
                    Console.WriteLine("ERROR. Type C for circle, S for square");
                    break;
            }
        }
    }
}
