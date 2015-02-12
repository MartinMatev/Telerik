using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ProgrammingLanguages
{
    class Languages
    {
        // Perform a research (e.g. in Google or Wikipedia) and provide a short list with information about the most popular programming languages. 
        // How similar are they to C#? How do they differ from C#?
        // Write in a text file called “programming-languages.txt” at least five languages along with 2-3 sentences about each of them. Use English.
        static void Main(string[] args)
        {
            // If this doesn't work, you can always double click the text file.

            string path = Directory.GetCurrentDirectory();
            //Console.WriteLine("The current directory is {0}", path);
            try
            {
                string text = System.IO.File.ReadAllText(path + @"\programming-languages.txt");
                Console.WriteLine("Contents of \"programming-languages.txt\" below: \n{0}", text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("It seems that I have failed, please open the text document manually!");
                Console.WriteLine("The exception caught is: \n{0}", e.Message);
            }
        }
    }
}
