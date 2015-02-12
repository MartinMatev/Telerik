using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */ 
namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type in integers, separated by a space: ");
                string[] inputArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int count = inputArr.Count();
                int[] intArr = Array.ConvertAll(inputArr, int.Parse);
                int evenProduct = 1;
                int oddProduct = 1;

                for (int i = 1; i <= count; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenProduct *= intArr[i - 1];
                    }
                    else
                    {
                        oddProduct *= intArr[i - 1];
                    }
                }
                bool isEqual = evenProduct == oddProduct;
                Console.WriteLine("Result : {0}, \nEven product = {1}, \nOdd product = {2}", isEqual, evenProduct, oddProduct);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong data format!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }
    }
}
