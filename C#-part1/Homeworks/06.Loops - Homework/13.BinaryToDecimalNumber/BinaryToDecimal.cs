using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.
namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number to convert to decimal: ");
            string input = Console.ReadLine();
            long counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // Start checking the string element from last to first.Continue if its zero.
                if (input[input.Length - i - 1] == '0')
                {
                    continue;
                }
                counter += (long)Math.Pow(2, i);
            }
            Console.WriteLine(counter);
        }
    }
}
