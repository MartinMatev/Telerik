using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.
namespace _15.HexadecimalToDecimalNumber
{
    class HexademicalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexademical number: ");
            string input = Console.ReadLine().ToUpper();
            long decimalNum = 0;
            int parsedValue;
            int power = input.Length;

            for (int i = 0; i < input.Length; i++)
            {
                // Power of 16 decreases by 1 from left to right for each number
                power--;
                // Calls the HexademicalValue method in order to parse correctly the char element of the string (input[i]) to int
                parsedValue = HexademicalValue(input[i]);
                // Calculates decimal equivalent by multiplying the parsed number by 16 on power(the input's lenght-- for each iteration)
                decimalNum += parsedValue * (long)Math.Pow(16, power);
            }
            Console.WriteLine("The decimal equivalent of your hexademical number is : {0}", decimalNum);
        }
        public static int HexademicalValue(char hexValue)
        {
            switch (hexValue)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    // System.Char's build in static method for convertion
                    return (int)Char.GetNumericValue(hexValue);
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    return 0;
            }
        }
    }
}
