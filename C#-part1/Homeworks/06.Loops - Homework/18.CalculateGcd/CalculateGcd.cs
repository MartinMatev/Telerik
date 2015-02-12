using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).
namespace _17.CalculateGcd
{
    class CalculateGcd
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first integer: ");
                int firstInteger = int.Parse(Console.ReadLine());
                Console.Write("Enter second integer: ");
                int secondInteger = int.Parse(Console.ReadLine());
                int divider = 0;
                int remainder = 0;

                // IF any of the numbers is 0, then the other one's value is the GCD!
                if (firstInteger == 0 || secondInteger == 0)
                {
                    Console.WriteLine("The geartest common divisor is: {0}", firstInteger == 0 ? secondInteger : firstInteger);
                }
                else
                {
                    // If the second int's value is greater than the first one's then we MUST swap their values!
                    if (firstInteger > secondInteger)
                    {
                        int temp = firstInteger;
                        firstInteger = secondInteger;
                        secondInteger = temp;
                    }
                    while (true)
                    {
                        if (firstInteger % secondInteger != 0)
                        {
                            divider = firstInteger / secondInteger;
                            remainder = firstInteger - (divider * secondInteger);
                            firstInteger = secondInteger;
                            secondInteger = remainder;
                            continue;
                        }
                        break;
                    }
                    Console.WriteLine("The greatest common divisor of your numbers is: {0}", secondInteger);
                }
            }
            catch (FormatException)
            {
                Console.Write("Wrong data format!");
            }

        }
    }
}
