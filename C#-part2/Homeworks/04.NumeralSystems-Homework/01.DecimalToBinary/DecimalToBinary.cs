using System;

// Write a program to convert decimal numbers to their binary representation.
class DecimalToBinary
{
    static void Main()
    {
        uint decimalNumber = GetDecimalNumber();
        if (decimalNumber > 0) {
            ConvertToBinary(decimalNumber);
            }
        else
        {
            PrintBinary(decimalNumber.ToString());
        }
    }

    private static void ConvertToBinary(uint decimalNumber)
    {
        string binaryNum = "";

        while (decimalNumber > 0)
        {
            int digit = (int)decimalNumber % 2;
            binaryNum = digit + binaryNum;
            decimalNumber /= 2;
        }
        PrintBinary(binaryNum);
    }

    private static void PrintBinary(string result)
    {
        Console.WriteLine("The binary representation of your number is: {0}", result);
    }

    private static uint GetDecimalNumber()
    {
        Console.Write("Enter a positive decimal number: ");
        uint number = uint.Parse(Console.ReadLine());
        return number;
    }
}