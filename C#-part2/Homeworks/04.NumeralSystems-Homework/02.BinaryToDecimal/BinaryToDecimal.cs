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
            // We take the LAST number of the input using the length-i-1 method and multiply it with the BASE of the binary system (2) ^ 0, then we take the second to last  * 2 ^ 1 etc... 
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