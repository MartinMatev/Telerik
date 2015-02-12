using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuadronacciRectangle
{
    static void Main(string[] args)
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long fourthNumber = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long result = 0;

        if (cols == 4)
        {
            Console.WriteLine("{0} {1} {2} {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
        else
        {
            Console.Write("{0} {1} {2} {3} ", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }

        for (int row = 0; row < rows; row++)
        {
            int currentCols = 0;
            if (row == 0)
            {
                currentCols = 4;
            }
            for (int col = currentCols; col < cols; col++)
            {
                result = firstNumber + secondNumber + thirdNumber + fourthNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = fourthNumber;
                fourthNumber = result;

                if (col + 1 == cols)
                {
                    Console.WriteLine(result);    
                }
                else
                {
                    Console.Write(result + " ");
                }
                
            }
        }
    }
}
