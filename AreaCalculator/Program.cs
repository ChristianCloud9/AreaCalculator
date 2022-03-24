using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an area you would like to calculate? ");

            string choice = "";
            Console.WriteLine("[1]Area of circle");
            Console.WriteLine("[2]Area of rectangle");
            Console.WriteLine("[3]Area of triangle");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                CircleArea();
                Again();
            }
            if (choice == "2")
            {
                RectangleArea();
                Again();
            }
            if (choice == "3")
            {
                TriangleArea();
                Again();
            }
            
        }

        private static void RectangleArea()    //Method for rectangle equation
        {
            double rectangleArea;
            double width;
            double length;

            Console.WriteLine("Please enter the width: ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length: ");
            length = double.Parse(Console.ReadLine());

            rectangleArea = width * length;
            Console.WriteLine("The area of the rectangle is " + rectangleArea);

        }

        private static void CircleArea()   // Method for circle equation 
        {
            double circleArea;
            double radius;
            const double pi = 3.14;

            Console.WriteLine("Please enter the radius: ");
            radius = double.Parse(Console.ReadLine());

            circleArea = pi * radius * radius;
            Console.WriteLine("The are of the circle is" + circleArea);
            
        }

        private static void TriangleArea()      // Method for triangle equation
        {
            double triangleArea;
            double height;
            double width;

            Console.WriteLine("Please enter the width: ");

            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height: ");

            height = double.Parse(Console.ReadLine());

            triangleArea = width * height / 2;

            Console.WriteLine("The area of the triangle is " + triangleArea);
        } 

        private static void Again()
        {
            string answer;
            Console.WriteLine("Want to do another calculation? [Y/N]");
            answer = Console.ReadLine();

            if (answer.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                string choice = "";
                Console.WriteLine("[1]Area of circle");
                Console.WriteLine("[2]Area of rectangle");
                Console.WriteLine("[3]Area of triangle");
                
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    CircleArea();
                    Again();
                }
                if (choice == "2")
                {
                    RectangleArea();
                    Again();
                }
                if (choice == "3")
                {
                    TriangleArea();
                    Again();
                }
                

            } 
            else
            {
                Console.WriteLine("You can close the program now.");
            }


        }
         

        

    }
}
