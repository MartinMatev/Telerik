using System;

// Write a program to convert binary numbers to their decimal representation
class BinaryToDecimal
{
    static void Main()
    {
        string input = GetBinaryNum();
        ConvertToDecimal(input);
    }

    private static void ConvertToDecimal(string binaryNumber)
    {
        long decimalNumber = 0;
        int length = binaryNumber.Length;
        for (int i = 0; i < length; i++)
        {
            decimalNumber += (binaryNumber[length - i - 1] - '0') * (long)Math.Pow(2, i);
        }
        PrintDecimalNumber(decimalNumber);
    }

    private static void PrintDecimalNumber(long decimalNumber)
    {
        Console.WriteLine("The decimal form of your binary number is: {0}", decimalNumber);
    }

    private static string GetBinaryNum()
    {
        Console.Write("Type in binary number: ");
        return Console.ReadLine();
    }
}