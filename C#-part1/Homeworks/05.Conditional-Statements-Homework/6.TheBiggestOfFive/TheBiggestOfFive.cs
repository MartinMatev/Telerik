using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the biggest of five numbers by using only five if statements.
namespace _6.TheBiggestOfFive
{
    class TheBiggestOfFive
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            double biggerNumber = 0;
            // For loop to fill up the double array with numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number {0} : ", i + 1);
                if (double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    // Assign the first element of the array as the biggest number
                    biggerNumber = numbers[0];
                    //Check if any of the other elements is bigger in value. If so, it becomes the new biggest number.
                    if (biggerNumber < numbers[1])
                    {
                        biggerNumber = numbers[1];
                    }
                    if (biggerNumber < numbers[2])
                    {
                        biggerNumber = numbers[2];
                    }
                    if (biggerNumber < numbers[3])
                    {
                        biggerNumber = numbers[3];
                    }
                    if (biggerNumber < numbers[4])
                    {
                        biggerNumber = numbers[4];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid data format!");
                }
            }
            Console.WriteLine("The biggest of the five is: {0}", biggerNumber);
        }
    }
}
