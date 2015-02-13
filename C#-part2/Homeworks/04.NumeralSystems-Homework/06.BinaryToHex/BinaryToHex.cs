using System;

// Write a program to convert binary numbers to hexadecimal numbers (directly).
class BinaryToHex
{
    static void Main()
    {
        string binaryNum = GetBinaryNum();
        ConvertToHex(binaryNum);
    }

    private static void ConvertToHex(string binaryNum)
    {
        string hexNum = "";
        int decimalNum = 0;
        int length = binaryNum.Length;

        for (int i = 0; i < length; i++)
        {

            int digit = (binaryNum[length - i - 1] - '0') * (int)Math.Pow(2, i);
            decimalNum += digit;
        }

        while (decimalNum != 0)
        {
            int remainder = decimalNum % 16;
            if (remainder >= 0 && remainder <= 9)
            {
                hexNum = remainder + hexNum;
            }
            else
            {
                // As magical as it might seem, 55 is the ASCII for 'A' -> 55 + 10 = A, 55 + 11 = B etc.
                hexNum = (char)(remainder + 55) + hexNum;
            }
            decimalNum /= 16;
        }
        PrintResult(hexNum);
    }

    private static void PrintResult(string hexNum)
    {
        Console.WriteLine("The hex representation of your binary is: {0}", hexNum);
    }

    private static string GetBinaryNum()
    {
        Console.Write("Enter binary num: ");
        return Console.ReadLine();
    }
}