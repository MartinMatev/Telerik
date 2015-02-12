using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        // Write a program that prints an isosceles triangle of 9 copyright symbols ©
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copy = '\u00a9';

            // Version 1 Hardcoded: Using only WriteLine 
            Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", copy);
            Console.WriteLine();

            // Version 2 Loops: Using a for loop 
            int rows = 5;
            string space;

            // Print out the top 
            Console.WriteLine(Indent(rows - 1) + copy);
            for (int i = 0; i < 3; i++)
            {
                // Calculate and Add appropriate spaces for each iteration
                space = new String(' ', i * 2 + 1);

                // A check for the last row, break out of the cycle after the WriteLine
                if (i == 2)
                {
                    Console.WriteLine(Indent(rows - i - 2) + "{0} {0} {0} {0}", copy);
                    break;
                }
                // Prints out the rows with appropriate indent and spaces, based on the iteration counter
                Console.WriteLine(Indent(rows - i - 2) + copy + space + copy);
            }
        }
        // A method for implementing indent (spaces before the copy sign)
        public static string Indent(int count)
        {
            // Returns number of spaces to the left, based on the number with which the function was called
            return "".PadLeft(count);
        }
    }
}
