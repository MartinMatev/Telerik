using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionalit
namespace _14.DesimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter (long) number: ");
            long number;
            if (long.TryParse(Console.ReadLine(), out number))
            {
                string decimalNum = String.Empty;
                while (number > 0)
                {
                    // Is there's a remainder after the division, type in "1"
                    if (number % 2 != 0)
                    {
                        decimalNum += "1";
                    }
                    else
                    {
                        decimalNum += "0";
                    }
                    number /= 2;
                }
                // Reverses the string data(since its backwards after the loop)
                // by converting it to char array and using the array's reverse method
                char[] charArray = decimalNum.ToCharArray();
                Array.Reverse(charArray);
                decimalNum = new string(charArray);
                // Check if string is still empty (number entered is zero). If not return the value, else return 0
                Console.WriteLine("The binary form of your decimal number is: {0}", decimalNum != String.Empty? decimalNum : "0");
            }
        }
    }
}
