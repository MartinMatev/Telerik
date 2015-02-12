using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CsharpVsDotNet
{
    class CsharpDotNet
    {
        // Describe the difference between C# and .NET Framework in 2-3 sentences.
        // Write your description in a text file called “csharp-and-dot-net-framework.txt”. Use English
        static void Main(string[] args)
        {

            // If this doesn't work, you can always double click the text file.

            string path = Directory.GetCurrentDirectory();
            //Console.WriteLine("The current directory is {0}", path);
            try
            {
                string text = System.IO.File.ReadAllText(path + @"\csharp-and-dot-net-framework.txt");
                Console.WriteLine("Contents of \"csharp-and-dot-net-framework.txt\" below: \n{0}", text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("It seems that I have failed, please open the text document manually!");
                Console.WriteLine("The exception caught is: \n{0}", e.Message);
            }
        }
    }
}
