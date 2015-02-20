using System;
using System.Globalization;

/*
 * Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
Example:

number	    sign	exponent	mantissa
-27.25	    1	    10000011	10110100000000000000000
 */
class BinaryFloatingPoint
{
    static void Main()
    {
        float number = GetNumber();
        ConvertToBits(number);
    }

    private static void ConvertToBits(float floatNumber)
    {
        int decimalNumber = BitConverter.ToInt32(BitConverter.GetBytes(floatNumber), 0);
        string numberInBits = Convert.ToString(decimalNumber, 2);   // Converts the float number to string and to it's binary format
        ExtractParts(numberInBits);
    }

    private static void ExtractParts(string numberInBits)
    {
        // Extracts bit 1 for the sign, bits 2 to 9 for the exponent and bits 10 to 32 for the mantissa
        string sign = numberInBits[0].ToString();
        string exponent = numberInBits.ToString().Substring(1, 8);
        string mantissa = numberInBits.ToString().Substring(9); 
        PrintResult(sign, exponent, mantissa);
    }

    private static void PrintResult(string sign, string exponent, string mantissa)
    {
        Console.WriteLine("sign: {0}, exponent: {1}, mantissa: {2}", sign, exponent, mantissa);
    }

    private static float GetNumber()
    {
        Console.Write("Enter your float number: ");
        return float.Parse(Console.ReadLine());
    }
}
