using System;
using System.Collections.Generic;

namespace Shapes
{
    class Tests
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5, 6),
                new Triangle(3, 2),
                new Square(8)
            };

            Console.WriteLine("Areas calculations: ");
            foreach (Shape figure in shapes)
            {
                Console.WriteLine("Area of the {0} is {1}", figure.ToString(), figure.CalculateSurface());
            }
        }
    }
}
