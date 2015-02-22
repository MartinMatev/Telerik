using System;
using System.Text.RegularExpressions;

/*
 * Write a program for extracting all email addresses from given text.
 * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
class ExtractEmails
{
    static void Main()
    {
        string text = "Yesterday, I saw a creepyguy@abv.bg so I ran for my effin live, hoping there was a policeman@yahoo.mail nearby.";
        string emailTemplate = @"\w+@\w+\.\w+";

        foreach (var match in Regex.Matches(text, emailTemplate))
	    {
		 Console.WriteLine("Pls work: {0}", match);
	    }
    }
}
