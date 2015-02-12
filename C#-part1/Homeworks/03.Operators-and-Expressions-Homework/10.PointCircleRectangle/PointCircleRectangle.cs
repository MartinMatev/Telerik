using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointCircleRectangle
{
    class PointCircleRectangle
    {
        // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
        //and out of the rectangle R(top=1, left=-1, width=6, height=2).
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type in the point's coordinates");
                Console.Write("Type in x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Type in y: ");
                double y = double.Parse(Console.ReadLine());
                double circleRadius = 1.5;
                double rectangleTop = 1;
                double rectangleLeft = -1;
                double rectangleWidth = 6;
                double rectangleHeight = 2;

                // Returns true if the point is within the circle(using Pythagoras theorem), false otherwise
                bool inCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= circleRadius * circleRadius;
                if (inCircle)
                {
                    // Checks if the point is outside of the rectangle when it is already inside the circle
                    bool outsideRectangle = !((x >= rectangleLeft && x <= rectangleLeft + rectangleWidth) && (y >= rectangleLeft && y <= rectangleTop));

                    if (outsideRectangle)
                    {
                        Console.WriteLine("The point is IN the circle and OUTSIDE of the rectangle");
                    }
                    else
                    {
                        Console.WriteLine("The point is OUTSIDE of the rectangle");
                    }
                }
                else
                {
                    Console.WriteLine("The point is outside the circle");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The data is of the wrong format!");
            }

        }
    }
}
