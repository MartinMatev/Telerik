using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the biggest of three numbers.
namespace _5.TheBiggestOfThree
{
    class TheBiggestOfThree
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double third = double.Parse(Console.ReadLine());

            
            if (first == second && second == third)
            {
                Console.WriteLine("They are all equal to: {0}", first);
            }
            else if (first >= second)
            {
                if (first >= third)
                {
                    Console.WriteLine("The biggest of the three is : {0}", first);
                }
                else if (first <= third)
                {
                    Console.WriteLine("The biggest of the three is : {0}", third);
                }
            }
            else if (first <= second)
            {
                if (second >= third)
                {
                    Console.WriteLine("The biggest of the three is : {0}", second);
                }
                else if (second <= third)
                {
                    Console.WriteLine("The biggest of the three is : {0}", third);
                }
            }
        }
    }
}
