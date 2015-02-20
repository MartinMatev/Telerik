using System;

// Write a program to convert hexadecimal numbers to binary numbers (directly).
class HexToBinary
{
    static void Main(string[] args)
    {
        string hexNum = GetHexNum();
        ConvertToBinary(hexNum);
    }
    private static void ConvertToBinary(string hexNum)
    {
        string binaryNum = "";
        int length = hexNum.Length;

        for (int i = 0; i < length; i++)
        {
            char digit = hexNum[length - i -1];
            int decimalDigit = 0;
            // Check if number is 0-9 , else it's A-F
            if (digit - '0' >= 0 && digit - '0' <= 9)
            {
                decimalDigit = digit - '0';
               
            }
            else
            {
                // Lets say digit contains 'C'-> the ASCII representation of 'C' is 67; 67 - 65 (ASCII for 'A') = 2; 2 + 10 = 12 (which is the decimal representation of 'C').
                decimalDigit = (digit - 'A') + 10;
            }

            while (decimalDigit != 0)
            {
                int remainder = decimalDigit % 2;
                binaryNum = remainder + binaryNum;
                decimalDigit = decimalDigit / 2;
            }
        }
        PrintResult(binaryNum);
    }

    private static void PrintResult(string binaryNum)
    {
        Console.WriteLine("The binary representation of your hex is: {0}", binaryNum);
    }

    private static string GetHexNum()
    {
        Console.Write("Enter hex number: ");
        return Console.ReadLine().ToUpper();
    }
}
