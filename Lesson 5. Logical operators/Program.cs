//namespace . For logical separation of classes
namespace Logic
{
    class Program
    {
        //Program to show logical operations, primitive data types
        static void Main(string[] args)
        {
            IfElseRun();
            SwitchRun();         
        }

        //method introduction
        private static void IfElseRun()
        {
            Console.WriteLine("PLease enter type of shape. Type C for circle, R for rectange, S for square");
            //Char - contain one letter. Primitive data type
            //access 1st element of char array here
            char figure = Console.ReadLine()[0];

            //Casting here. Logical operators OR
            //result of if statement is boolean type
            if((figure == (char)'C') || (figure == 'R') || (figure == 'S'))
            {
                if (figure == 'C')
                {
                    //Creating struct here
                    Circle c = new Circle(3, 0, 0);
                    Console.WriteLine("Circle area = " + c.GetArea());
                }   
            }
            //use of if .. else
            else
            {
                Console.WriteLine("ERROR. Type C for circle, R for rectange, S for square");
            }           
        }

        private static void SwitchRun()
        {
            Console.WriteLine("PLease enter type of shape. Type C for circle, R for rectange, S for square");
            //Char - contain one letter. Primitive data type
            //access 1st element of char array here
            char figure = Console.ReadLine()[0];

            //Casting here. Logical operators OR
            //result of if statement is boolean type
            if((figure == (char)'C') || (figure == 'R') || (figure == 'S'))
            {
                if (figure == 'C')
                {
                    //Creating struct here
                    Circle c = new Circle(3, 0, 0);
                    Console.WriteLine("Circle area = " + c.GetArea());
                }   
            }
            //use of if .. else
            else
            {
                Console.WriteLine("ERROR. Type C for circle, R for rectange, S for square");
            }           
        }
    }
}
