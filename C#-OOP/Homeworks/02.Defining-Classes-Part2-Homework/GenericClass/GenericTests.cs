using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class GenericTests
    {
        static void Main()
        {
            // Testing the AddElement method
            GenericList<int> testList = new GenericList<int>();
            testList.AddElement(2);
            testList.AddElement(5);
            testList.AddElement(12);

            Console.WriteLine("testList contains the following values: ");
            Console.WriteLine(testList.ToString());

            // Testing the Add Element at Index method
            Console.WriteLine("\nElement \"1337\" added at index 1!");
            testList.AddElementAtIndex(1337, 1);
            Console.WriteLine(testList.ToString());

            // Testing the get element at index method
            Console.WriteLine("\nElement at index 2: ");
            Console.WriteLine(testList[2]);

            // Testing the Get Index of passed element method
            Console.WriteLine("\nThe index of element \"1337\" is: ");
            Console.WriteLine(testList.IndexOfElement(1337));

            // Testing the remove last element method
            Console.WriteLine("\nLast element removed!");
            testList.RemoveElement();
            Console.WriteLine(testList.ToString());
            
            // Testing the Remove Element at Index method
            Console.WriteLine("\nElement \"1337\" at index 1 removed!");
            testList.RemoveElementAtIndex(1);
            Console.WriteLine(testList.ToString());

            // Testing the FIND MIN method
            Console.WriteLine("\nThe min element of the generic list is: ");
            Console.WriteLine(testList.Min(testList));

            // Testing the FIND MAX method
            Console.WriteLine("\nThe max element of the generic list is: ");
            Console.WriteLine(testList.Max(testList));

            // Clear the generic list
            testList.Clear();
            Console.WriteLine("\nGeneric list cleared !");
            Console.WriteLine(testList.ToString());
        }
    }
}
