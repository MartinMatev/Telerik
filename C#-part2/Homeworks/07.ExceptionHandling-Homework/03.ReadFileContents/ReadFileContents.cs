using System;
using System.IO;

/*
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents 
 * and prints it on the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 */
class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Enter the full (absolute) path to the file, including it's name and extension");
        Console.WriteLine(@"Example: C:\WINDOWS\win.ini");
        Console.Write(">> ");
        string input = Console.ReadLine();
        
        try
        {
            string text = File.ReadAllText(input);
            Console.WriteLine("Contents of your file: {0}", text);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileLoadException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DriveNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}

/*
 * Can't even get half of the errors above, they are listed as possibilities though:
 * https://msdn.microsoft.com/en-us/library/system.io.ioexception(v=vs.110).aspx
*/