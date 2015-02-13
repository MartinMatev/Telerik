using System;
using System.Text;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
class BinaryShort
{
    static void Main()
    {
        short number = GetNumber();
        ConvertToBinary(number);
    }

    private static void ConvertToBinary(short number)
    {
        string binaryNumber = "";
        for (int i = 0; i < 16; i++)
        {
            // Grab a bit, bitwise & it to 1 and put in INFRONT of the previous one in the binaryNumber string
            binaryNumber = ((number >> i) & 1) + binaryNumber; 
        }
        PrintResult(binaryNumber);
    }

    private static void PrintResult(string binaryNumber)
    {
        Console.WriteLine("Binary representation of your short number: {0}", binaryNumber);
    }

    private static short GetNumber()
    {
        Console.Write("Enter a number between {0} and {1}: ", short.MinValue, short.MaxValue);
        return short.Parse(Console.ReadLine());
    }
}