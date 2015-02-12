using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DevelopmentEnvironments
{
    class DevEnviromnets
    { 
        //Perform a research (e.g. in Google or Wikipedia) and provide a short list with popular development environments (IDEs) like Visual Studio.
        //Write in a text file called “list-of-IDEs.txt” at least five IDEs along with 2-3 sentences about each of them. Use English.
        static void Main(string[] args)
        {
            // If this doesn't work, you can always double click the text file.

            string path = Directory.GetCurrentDirectory();
            //Console.WriteLine("The current directory is {0}", path);
            try
            {
                string text = System.IO.File.ReadAllText(path + @"\list-of-IDEs.txt");
                Console.WriteLine("Contents of \"list-of-IDEs.txt\" below: \n{0}", text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("It seems that I have failed, please open the text document manually!");
                Console.WriteLine("The exception caught is: \n{0}", e.Message);
            }
        }        
    }
}
