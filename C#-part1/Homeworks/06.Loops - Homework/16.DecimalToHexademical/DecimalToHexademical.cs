using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.
namespace _16.DecimalToHexademical
{
    class DecimalToHexademical
    {
        static void Main(string[] args)
        {
            Console.Write("Enter (long) number: ");
            long decimalNum;
            long remainder;
            string hexademicalNum = String.Empty;

            if (long.TryParse(Console.ReadLine(), out decimalNum))
            {
                while (decimalNum > 0)
                {
                    remainder = decimalNum % 16;
                    if (remainder >= 10 && remainder <= 15)
                    {
                        hexademicalNum += HexademicalValue(remainder, hexademicalNum);
                    }
                    else
                    {
                        hexademicalNum += remainder;
                    }
                    decimalNum /= 16;
                }
                // Reverse the value of the string by switching it to an array and using it's .Reverse() method
                char[] charArray = hexademicalNum.ToCharArray();
                Array.Reverse(charArray);
                hexademicalNum = new string(charArray);

                Console.WriteLine("The hexademical value of your decimal number is: {0}", hexademicalNum);
            }
        }
        public static string HexademicalValue(long number, string hexValue)
        {
            switch (number)
            {
                case 10:
                    hexValue = "A";
                    break;
                case 11:
                    hexValue = "B";
                    break;
                case 12:
                    hexValue = "C";
                    break;
                case 13:
                    hexValue = "D";
                    break;
                case 14:
                    hexValue = "E";
                    break;
                case 15:
                    hexValue = "F";
                    break;
                default:
                    break;
            }
            return hexValue;
        }
    }
}
