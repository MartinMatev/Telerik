using System;
using System.Text;

/*
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be filled with *.
 * Print the result string into the console.
 */
class StringLength
{
    static void Main()
    {
        try
        {
            StringBuilder input = GetInput();

            while (input.Length < 20)
            {
                input.Append('*');
            }
            Console.WriteLine(input.ToString());
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static StringBuilder GetInput()
    {
        Console.WriteLine("Enter thy string (no more than 20 symbols length, or else...): ");
        Console.Write(">> ");
        StringBuilder input = new StringBuilder();
        input.Append(Console.ReadLine());

        if (input.Length > 20)
        {
            throw new ArgumentOutOfRangeException();
        }
        return input;

    }
}
