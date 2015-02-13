using System;

// Write a program to convert hexadecimal numbers to their decimal representation.
class HexToDecimal
{
    static void Main()
    {
        string hexNum = GetHexNum();
        ConvertToDecimal(hexNum);
    }

    private static void ConvertToDecimal(string hexNum)
    {
        int length = hexNum.Length;
        long decimalNum = 0;
        for (int i = 0; i < length; i++)
        {
            char digit = hexNum[i];
            if (digit >= '0' && digit <= '9')
            {
                decimalNum += (digit - '0') * (int)Math.Pow(16, length - i - 1);
            }
            else if (digit >= 'A' && digit <= 'F')
            {
                decimalNum += (digit - 'A' + 10) * (int)Math.Pow(16, length - i - 1);
            }
        }
        PrintResult(decimalNum);       
    }

    private static void PrintResult(long decimalNum)
    {
        Console.WriteLine("The decimal representation of your hex number is: {0}", decimalNum);
    }

    private static string GetHexNum()
    {
        Console.Write("Enter hexademical number: ");
        string hexNum = Console.ReadLine().ToUpper();
        return hexNum;
    }
}