using System;
using System.IO;

// Write a program that concatenates two text files into another text file.
class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFilePath = @"../../../ProblemsTextFolder/02.FileOne.txt";
        string secondFilePath = @"../../../ProblemsTextFolder/02.FileTwo.txt";
        string resultFilePath = @"../../../ProblemsTextFolder/02.ResultFile.txt";

        try
        {
            string firstFileContents = File.ReadAllText(firstFilePath);
            string secondFileContents = File.ReadAllText(secondFilePath);

            using (TextWriter fileWriter = new StreamWriter(resultFilePath))
            {
                fileWriter.WriteLine(firstFileContents + secondFileContents);
            }
            Console.WriteLine("New file was created at : {0}", Path.GetFullPath(resultFilePath));
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (EndOfStreamException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
