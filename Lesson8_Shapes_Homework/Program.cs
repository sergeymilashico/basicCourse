using System;

namespace Lesson8_Shapes_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circleArray = new Circle[10];
            Square[] squareArray = new Square[10];
            int i = 0;
            int j = 0;


            while (true)
            {
                Console.WriteLine("Please enter C for circle, S for square, Q to exit");
                var userInput = Console.ReadKey().KeyChar;
                if (userInput == 'C')
                {
                    Console.WriteLine("Please enter radius of the circle : ");
                    var radiusText = Console.ReadLine();
                    int radius = 0;
                    if (radiusText != null)
                    {
                        radius = Convert.ToInt32(radiusText);
                    }

                    var circle = new Circle(radius);
                    circleArray[i] = circle;
                    i++;
                }
                else if (userInput == 'S')
                {
                    Console.WriteLine("Please enter side of the square : ");
                    var side = Convert.ToInt32(Console.ReadLine());
                    var square = new Square(side);
                    squareArray[j] = square;
                    j++;
                }
                else if (userInput == 'Q')
                {
                    break;
                }

                //if user did not enter C,S or Q
                else
                {
                    Console.WriteLine("You entered wrong symbol");
                    continue;
                }
            }

            //variable for total sum
            double totalSum = 0;
            for (var ii = 0; ii < circleArray.Length; ii++)
            {
                totalSum += circleArray[ii].GetArea();
            }


            foreach (var square in squareArray)
            {
                if (square != null)
                {
                    double area = square.GetArea();
                    totalSum += area;
                }

            }

            Console.WriteLine($"Total area of all entered shapes = {totalSum}");
            Console.ReadLine();
        }
    }

}
