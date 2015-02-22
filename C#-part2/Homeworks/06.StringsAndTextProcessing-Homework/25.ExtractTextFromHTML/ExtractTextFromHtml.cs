using System;
using System.Linq;
using System.Text;

/*
 * Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
 * 
 * Example input:
 * 
 * <html>
 * <head><title>News</title></head>
 * <body><p><a href="http://academy.telerik.com">Telerik
 * Academy</a>aims to provide free real-world practical
 * training for young people who want to turn into
 * skilful .NET software engineers.</p></body>
 * </html>
 * 
 * Output:
 * Title: News
 * Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
 */
class ExtractTextFromHtml
{
    static void Main()
    {
        string htmlText = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        // Not using REGEX this time, although the Regex solution is the same as every assignment before this one, and its around 3 times smaller in size, because reasons.
        ExtractInformation(htmlText);
    }

    private static void ExtractInformation(string htmlText)
    {
        StringBuilder bodyText = new StringBuilder();
        StringBuilder title = new StringBuilder();
        bool isInTag = false;

        for (int i = 0; i < htmlText.Length; i++)
        {
            if (!isInTag)
            {
                if (htmlText[i] == '<' && htmlText[i + 1] != 't')   // a check if we are in a TAG and its NOT <title>
                {
                    isInTag = true;
                }
                else if (htmlText[i] == '<' && htmlText[i + 1] == 't')  // a check if we are in a TAG and IT IS <title>
                {
                    int currentIndex = i;
                    while (htmlText[currentIndex] != '>')   // Loop the currentIndex until we are out of the TAG
                    {
                        currentIndex++;
                    }

                    while (htmlText[currentIndex + 1] != '<')   // Once we are out, loop until we meet the opening of the closing tag '<' and assign the chars to the TITLE StringBuilder
                    {
                        currentIndex++;
                        title.Append(htmlText[currentIndex]);
                    }

                    i = currentIndex - 1;   // Set the index `i` to the value of the current index(wich is at the START of the </title>) - 1, because the for cycle will ++ it as soon as it gets there.
                    isInTag = true; // Set that we are in a TAG now (</title> in particular)
                }
                else
                {
                    bodyText.Append(htmlText[i]);
                }
            }
            else
            {
                if (htmlText[i] == '>')
                {
                    // Adds a SPACE before chars, right after the closing tag '>', so they doesnt concatenate with chars, that are right before an opening tag '<'
                    if (i + 1 < htmlText.Length - 1 && htmlText[i + 1] != '<')
                    {
                        bodyText.Append(" ");
                    }
                    isInTag = false;
                }
                else
                {
                    continue;
                }
            }
        }
        PrintResult(title.ToString(), "Title");
        PrintResult(bodyText.ToString(), "Text");
    }

    private static void PrintResult(string result, string type)
    {
        Console.WriteLine("{0}: {1}", type, result);
    }
}