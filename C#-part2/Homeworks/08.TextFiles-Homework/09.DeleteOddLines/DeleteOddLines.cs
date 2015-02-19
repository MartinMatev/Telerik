using System;
using System.IO;

// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.
class DeleteOddLines
{
    static void Main()
    {
        string filePath = @"../../../ProblemsTextFolder/09.WillDeleteOddLines.txt";

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            
            // Displaying the original file, before the changes
            Console.WriteLine("Contents of original file: ");
            PrintFile(lines);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
            Console.WriteLine("\nReworked file has been saved at : {0}\n", Path.GetFullPath(filePath));

            lines = File.ReadAllLines(filePath);
            // Displaying the reworked file, after the changes
            Console.WriteLine("Contents of reworked file: ");
            PrintFile(lines);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (EndOfStreamException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void PrintFile(string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
