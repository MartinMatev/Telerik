using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValues
{
    class NullValues
    {
        // Create a program that assigns null values to an integer and to a double variable.
        // Try to print these variables at the console.
        // Try to add some number or the null literal to these variables and print the result.
        static void Main(string[] args)
        {
            // Decalre int and double variables which can be null
            int? integerNumber = 1337;
            double? doubleNumber = 13.37;
            Console.WriteLine("Original values - int: {0}, double: {1}\n", integerNumber, doubleNumber);

            // initialize the variables with NULL values
            integerNumber = null; 
            doubleNumber = null;
            Console.WriteLine("Check if variables have values after nullification (returns True if there is a value, False if it's NULL):");
            Console.WriteLine("integerNumber: {0}, doubleNumber: {1}\n", integerNumber.HasValue, doubleNumber.HasValue);

            // Add numbers to the null value containing variables, display the result
            Console.WriteLine("Adding 1337 to the integer and 13.37 to the double variable\n");
            integerNumber += 7331;
            doubleNumber += 73.31;
            Console.WriteLine("Checking if the variables have values after the adding:");
            Console.WriteLine("intNumber: {0}, doubleNumber: {1}\n", integerNumber.HasValue, doubleNumber.HasValue);

            // Assign integerNumber and doubleNumber to new variables.
            // If they are NULL, the new variables will be assigned the values after the double quotation mark.
            int newInt = integerNumber ?? 1111;
            double newDouble = doubleNumber ?? 3333.7777;
            Console.WriteLine("Value of newInt: {0} and newDouble: {1}", newInt, newDouble);
        }
    }
}
