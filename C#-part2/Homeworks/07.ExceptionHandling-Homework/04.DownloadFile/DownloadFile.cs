using System;
using System.IO;
using System.Net;

/*
 * Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
 * Find in Google how to download files in C#.
 * Be sure to catch all exceptions and to free any used resources in the finally block.
 */
class DownloadFile
{
    static void Main()
    {

        string remotePath = @"http://telerikacademy.com/Content/Images/news-img01.png";
        string fileName = "DownloadedNINJA.jpg";
       
        try
        {
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(remotePath, fileName);
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, remotePath);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("The picture has been downloaded to  {0}.", Directory.GetCurrentDirectory());
    }
}