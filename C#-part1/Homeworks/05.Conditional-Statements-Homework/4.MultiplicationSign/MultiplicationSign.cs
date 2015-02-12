using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.
namespace _4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            try 
            {
                double[] inputNumbers = new double[3];
                int counter = 0;
                bool isntZero = true;
                // For loop for inputing three numbers and filling up the array
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    Console.Write("Enter number {0}: ", i + 1);
                    inputNumbers[i] = Convert.ToDouble(Console.ReadLine());
                }
                //Loop through each assigned number and perform checks on each one
                foreach (double number in inputNumbers)
                {
                    // If the number is zero, break the loop, for anything multiplied by 0, equals 0.
                    if (number == 0)
                    {
                        Console.WriteLine("0");
                        isntZero = false;
                        break;
                    }
                    else if (number < 0)
                    {
                        // If the number is negative, add 1 to the counter
                        counter++;
                    }
                }
                if ((counter == 1 || counter == 3) && isntZero)
                {
                    Console.WriteLine("-");
                }
                else if (isntZero)
                {
                    Console.WriteLine("+");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
        }
    }
}
