using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */ 
namespace _9.IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1--->Int \n2--->Double \n3--->string");
            Console.Write("Please choose a type: ");
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                // Swtich the type value and depending on it, apply the appropriate code
                switch (input)
                {
                    case 1:
                        Console.Write("Enter int: ");
                        int intNum;
                        // Parse the int to be sure its an actual int
                        if (int.TryParse(Console.ReadLine(), out intNum))
                        {
                            intNum++;
                            Console.WriteLine("Your number is now: {0}", intNum);
                        }
                        break;
                    case 2:   
                        Console.Write("Enter double: ");
                        double doubleNum;
                        //Parse the double, to be sure its an actual double value
                        if (double.TryParse(Console.ReadLine(), out doubleNum))
                        {
                            doubleNum++;
                            Console.WriteLine("Your number is now: {0}", doubleNum);
                        }
                        break;
                    case 3:
                        Console.Write("Enter your string: ");
                        string stringInput = Console.ReadLine();
                        Console.WriteLine("Your string is now: {0}", stringInput + '*');
                        break;
                }
            }
        }
    }
}
