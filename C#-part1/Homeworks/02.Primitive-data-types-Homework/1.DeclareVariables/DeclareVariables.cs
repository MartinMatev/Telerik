using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DeclareVariables
{
    class DeclareVariables
    {
        // Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
        // to represent the following values: 52130, -115, 4825932, 97, -10000.
        // Choose a large enough type for each number to ensure it will fit in it. Try to compile the code
        static void Main(string[] args)
        {
            ushort numberOne = 52130;
            sbyte numberTwo = -115;
            int numberThree = 4825932;
            byte numberFour = 97;
            short numberFive = -10000;

            Console.Write("First number: {0} is of type ushort. ", numberOne);
            Console.WriteLine("The range of ushort is: {0} : {1}", ushort.MinValue, ushort.MaxValue);
            Console.Write("Second number: {0} is of type sbyte. ", numberTwo);
            Console.WriteLine("The range of ushort is: {0} : {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.Write("Third number: {0} is of type int. ", numberThree);
            Console.WriteLine("The range of ushort is: {0} : {1}", int.MinValue, int.MaxValue);
            Console.Write("Fourth number: {0} is of type byte. ", numberFour);
            Console.WriteLine("The range of ushort is: {0} : {1}", byte.MinValue, byte.MaxValue);
            Console.Write("Fifth number: {0} is of type short. ", numberFive);
            Console.WriteLine("The range of ushort is: {0} : {1}", short.MinValue, short.MaxValue);
        }
    }
}
