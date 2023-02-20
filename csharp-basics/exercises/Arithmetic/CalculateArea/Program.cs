using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            int menuAnswer = GetMenu();
            switch (menuAnswer)
            {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid input" );
                    break;
            }
            Console.ReadKey();
        }

        public static int GetMenu()
        {

            int userChoice = 0;
            


            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            // get input from user
            var keyboard = Convert.ToInt32(Console.ReadLine());
            bool isMatch = Regex.IsMatch(keyboard.ToString(), "[1-4]");
            if (isMatch)
            {
                userChoice = keyboard;
            }
            return userChoice;

           
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            //todo
            int radius = Convert.ToInt32(Console.ReadLine());
            if (radius > 0)
            {
                Console.WriteLine("The circle's area is "
                        + Geometry.AreaOfCircle(radius));
            }
            else Console.WriteLine("ERROR, negative radius");
        }

        public static void CalculateRectangleArea()
        {
            
            

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            decimal length = Convert.ToInt32(Console.ReadLine());

            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            decimal width = Convert.ToInt32(Console.ReadLine()); 

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            
            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            //todo
            //read key value
            decimal ground = Convert.ToInt32(Console.ReadLine());

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            //read key value
            decimal height = Convert.ToInt32(Console.ReadLine());

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}