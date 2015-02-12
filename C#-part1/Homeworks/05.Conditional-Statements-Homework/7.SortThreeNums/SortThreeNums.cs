using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.
namespace _7.SortThreeNums
{
    class SortThreeNums
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in first num: ");
                double first = double.Parse(Console.ReadLine());
                Console.Write("Type in second num: ");
                double second = double.Parse(Console.ReadLine());
                Console.Write("Type in third num: ");
                double third = double.Parse(Console.ReadLine());

                if (first >= second)
                {
                    if (second >= third)
                    {
                        Console.WriteLine("{0}, {1}, {2}",first, second, third);
                    }
                    else if (first <= third)
                    {
                        Console.WriteLine("{0}, {1}, {2}", third, first, second);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", first, third, second);
                    }
                }
                else if (first <= second)
                {
                    if (first >= third)
                    {
                        Console.WriteLine("{0}, {1}, {2}", second, first, third);
                    }
                    else if (second <= third)
                    {
                        Console.WriteLine("{0}, {1}, {2}", third, second, first);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1}, {2}", second, third, first);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
