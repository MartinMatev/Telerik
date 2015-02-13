using System;

// Write a program to convert decimal numbers to their hexadecimal representation.
class DecimalToHex
{
    static void Main()
    {
        ulong decimalNum = GetDecimalNumber();
        if (decimalNum > 0)
        {
            ConvertToHex(decimalNum);
        }
        else
        {
            PrintResult(decimalNum.ToString());
        }
    }

    private static void ConvertToHex(ulong decimalNum)
    {
        string hexNum = "";

        while (decimalNum > 0)
        {
            int remainder = (int)(decimalNum % 16);
            if (remainder >= 0 && remainder <= 9)
            {
                hexNum = remainder + hexNum;
            }
            else
            {
                // As magical as it might seem, 55 is the ASCII for 'A'
                hexNum = (char)(remainder + 55) + hexNum;
            }
            decimalNum /= 16;
        }
        PrintResult(hexNum);
    }

    private static void PrintResult(string hexNum)
    {
        Console.WriteLine("The hexademical form of your number is : {0}", hexNum);
    }

    private static ulong GetDecimalNumber()
    {
        Console.Write("Enter a positive decimal number: ");
        ulong number = ulong.Parse(Console.ReadLine());
        return number;
    }
}
