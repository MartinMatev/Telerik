using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringsAndObjects
{
    class StringsAndObjects
    {
        // Declare two string variables and assign them with Hello and World.
        // Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
        // Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string stringCast = (string)helloWorld;
            Console.WriteLine(stringCast);
        }
    }
}
