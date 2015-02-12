using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.rectangles
{
    class Rectangles
    {
        // Write an expression that calculates rectangle’s perimeter and area by given width and height.
        static void Main(string[] args)
        {
            double width;
            double height;
            Console.Write("Type in the width of the rectangle: ");
            // Checks if parsing the input width data was succesfull
            if (double.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Type in the height of the rectangle: ");
                // Checks if parsing the input height data was succesfull
                if (double.TryParse(Console.ReadLine(), out height))
                {
                    double area = width * height;
                    double parameter = (2 * width) + (2 * height);
                    Console.WriteLine("The area of the rectangle is: {0}", area);
                    Console.WriteLine("The parameter is: {0}", parameter);
                }
                else
                {
                    Console.WriteLine("The height you entered is of the wrong format!");
                }
            }
            else
            {
                Console.WriteLine("The width you entered is of the wrong format!");
            }
        }
    }
}
