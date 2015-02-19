using System;
using System.IO;

/*
 * Write a program that compares two text files line by line and prints the number of lines 
 * that are the same and the number of lines that are different.
 * Assume the files have equal number of lines.
 */
class TextFileComparison
{
    static void Main()
    {
        string[] fileOne = File.ReadAllLines("../../../ProblemsTextFolder/04.FirstFile.txt");
        string[] fileTwo = File.ReadAllLines("../../../ProblemsTextFolder/04.SecondFile.txt");

        int matchCounter = 0;

        for (int i = 0; i < fileOne.Length; i++)
        {
            if (fileOne[i] == fileTwo[i])
            {
                matchCounter++;
            }
        }
        int differenceCounter = fileTwo.Length - matchCounter;

        Console.WriteLine("Contents of file 1: ");
        PrintFile(fileOne);
        Console.WriteLine("Contents of file 2: ");
        PrintFile(fileTwo);
        Console.WriteLine("Total matches found: {0}", matchCounter);
        Console.WriteLine("Total different lines: {0}", differenceCounter);
    }

    private static void PrintFile(string[] file)
    {
        for (int i = 0; i < file.Length; i++)
        {
            Console.WriteLine(file[i]);
        }
    }
}