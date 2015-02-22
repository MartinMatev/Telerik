using System;
using System.IO;

// Describe the strings in C#.
// What is typical for the string data type?
// Describe the most important methods of the String class.
class StringsInC
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        string filePath = @"../../../StringsTheory.txt";

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                // Ctrl-F5 for the wall of copy-pastery.
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
