using System;
using System.IO;

// Write a program that reads a text file and prints on the console its odd lines.
class OddLines
{
    static void Main()
    {
        try
        {
            string filaPath = @"../../../ProblemsTextFolder/01.Problem.txt";

            using (StreamReader currentStream = new StreamReader(filaPath))
            {
                int lineNumber = 1;
                string line = currentStream.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = currentStream.ReadLine();
                    lineNumber++;
                }
            }
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
}