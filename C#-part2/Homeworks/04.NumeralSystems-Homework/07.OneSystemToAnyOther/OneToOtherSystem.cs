using System;

// Write a program to convert from any numeral system of given base s 
// to any other numeral system of base d (2 ≤ s, d ≤ 16).
class OneToOtherSystem
{
    static void Main(string[] args)
    {
        int convertFrom = GetSystem("from");
        int convertTo = GetSystem("to");
        string number = NumberToConvert();
        ConvertNumber(number, convertFrom, convertTo);
    }

    private static void ConvertNumber(string number, int convertFrom, int convertTo)
    {
        // First, convert the `convertFrom` to decimal
        long decimalNum = ConvertBaseToDecimal(number, convertFrom);
        // Second, take the converted to decimal result, and convert it to `convertTo`
        ConvertDecimalToBase(decimalNum, convertTo, convertFrom);
        
    }

    private static void ConvertDecimalToBase(long decimalNum, int baseSystem, int baseSystemFrom)
    {
        string convertedNumber = "";

        while (decimalNum != 0)
        {
            int remainder = (int)(decimalNum % baseSystem);
            // Check if its a digit (0-9), else treat it like a upper case letter
            if (remainder >= 0 && remainder <= 9)
            {
                convertedNumber = remainder + convertedNumber;
            }
            else
            {
                convertedNumber = (char)(remainder + 55) + convertedNumber;
            }
            decimalNum /= baseSystem;
        }
        PrintResult(convertedNumber, baseSystemFrom, baseSystem);
    }

    private static void PrintResult(string convertedNumber, int fromSystem, int toSystem)
    {
        Console.WriteLine("Your converted number from base system {0}, to {1} is : {2}", fromSystem, toSystem, convertedNumber);
    }

    private static long ConvertBaseToDecimal(string number, int baseSystem)
    {
        long decimalNumber = 0;
        int length = number.Length;
        for (int i = 0; i < length; i++)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                decimalNumber += (number[length - i - 1] - '0') * (long)Math.Pow(baseSystem, i);
            }
            else
            {
                decimalNumber += (number[i] - 'A' + 10) * (int)Math.Pow(baseSystem, length - i - 1);
            }
        }
        return decimalNumber;
    }

    private static string NumberToConvert()
    {
        Console.Write("Type in number to convert: ");
        return Console.ReadLine().ToUpper();
    }

    private static int GetSystem(string system)
    {
        Console.Write("Enter a system to convert {0}: ", system);
        return int.Parse(Console.ReadLine());
    }
}
