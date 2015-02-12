using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PointInCircle
{
    class PointInCircle
    {
        // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)
        static void Main(string[] args)
        {
            int radius = 2;
            try
            {
                Console.WriteLine("Please type in the point's coordinates");
                Console.Write("Type in x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Type in y: ");
                double y = double.Parse(Console.ReadLine());

                // Check if its WITHIN (<) or ON (=) the borders of the circle
                bool inCircle = (x * x) + (y * y) <= radius * radius;
                if (inCircle)
                {
                    Console.WriteLine("The point, with coordinates you just entered is WITHIN the circle");
                }
                else
                {
                    Console.WriteLine("The point, with coordinates you just entered is OUTSIDE the circle");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
