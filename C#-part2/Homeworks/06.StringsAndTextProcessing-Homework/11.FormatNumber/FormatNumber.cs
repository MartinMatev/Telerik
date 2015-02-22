using System;

/*
 * Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
 * Format the output aligned right in 15 symbols.
 */
class FormatNumber
{
    static void Main()
    {
        try
        {
            int inputNumber = GetInput();
            Console.WriteLine("Dec form: {0,15:D}", inputNumber);
            Console.WriteLine("Hex form: {0,15:X}", inputNumber);
            Console.WriteLine("Percentage: {0,15:P}", inputNumber);
            Console.WriteLine("Sci notaion: {0,15:E}", inputNumber);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static int GetInput()
    {
        Console.Write("Enter your integer number: ");
        return int.Parse(Console.ReadLine());
    }
}
