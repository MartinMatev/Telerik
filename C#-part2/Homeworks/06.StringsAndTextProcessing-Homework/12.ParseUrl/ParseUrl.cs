using System;

/*
 * Write a program that parses an URL address given in the format: 
 * [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 * Example:
 * 
 * URL:	
 * http://telerikacademy.com/Courses/Courses/Details/212
 * 
 * Information:
 * [protocol] = http 
 * [server] = telerikacademy.com 
 * [resource] = /Courses/Courses/Details/212
 */
class ParseUrl
{
    static void Main()
    {
        string url = GetUrl();
        UrlParser(url);
    }

    private static void UrlParser(string url)
    {
        // Make a new object called currentUrl of the Uri class (guess thats a thing in .Net)
        Uri currentUrl = new Uri(url);

        // Use demonic powers to initialize the variables. Also the Uri class functionality.
        string protocol = currentUrl.Scheme;
        string server = currentUrl.Host;
        string resources = currentUrl.AbsolutePath;
        string absoluteUrl = currentUrl.AbsoluteUri;
        PrintResult(absoluteUrl, protocol, server, resources);
    }

    private static void PrintResult(string absoluteUrl, string protocol, string server, string resources)
    {
        Console.WriteLine("\n{0}\n", absoluteUrl);
        Console.WriteLine("[{0}] = {1}", "protocol", protocol);
        Console.WriteLine("[{0}] = {1}", "server", server);
        Console.WriteLine("[{0}] = {1}", "resources", resources);
    }

    private static string GetUrl()
    {
        Console.WriteLine("Enter the URL to be parsed bewlow: ");
        Console.Write(">>");
        return Console.ReadLine();
    }
}