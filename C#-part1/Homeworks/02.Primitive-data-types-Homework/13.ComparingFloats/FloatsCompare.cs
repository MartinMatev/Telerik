using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class FloatsCompare
    {
        // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first double number: ");
                double firstNum = double.Parse(Console.ReadLine());
                Console.Write("Enter the second double number: ");
                double secondNum = double.Parse(Console.ReadLine());
                // A variable containing the minimal difference value
                double epsilon = 0.000001;
                // Find out the difference in absolute format
                double difference = Math.Abs(firstNum - secondNum);

                // Check if the difference between the two numbers is less than the minimum required value of epsilon
                if (difference < epsilon)
                {
                    Console.WriteLine("True");
                    Console.WriteLine("The number are EQUAL, with a precision of: {0}", epsilon);
                }
                else
                {
                    Console.WriteLine("False");
                    Console.WriteLine("The numbers are NOT equal, with a precision of: {0}", epsilon);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please type in viable floating point numbers!");
            }

        }
    }
}
