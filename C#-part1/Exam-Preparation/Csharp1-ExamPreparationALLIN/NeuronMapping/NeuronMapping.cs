using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronMapping
{
    class NeuronMapping
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            while (inputLine != "-1")
            {
                uint inputNumber = uint.Parse(inputLine);
                char[] numberBinaryDigits = Convert.ToString(inputNumber, 2).PadLeft(32, '0').ToCharArray();

                bool isInsideNeuron = false;
                bool isOnBoundary = false;
                bool beenInNeuron = false;
                // Обхождаме всяка 0 и 1чка на ЧИСЛО, което сме въвели (по 1 число на 1 итерация на WHILE !!!)
                for (int i = 0; i < numberBinaryDigits.Length; i++)
                {
                    //Ако сме стигнали начало(границата) на неврона
                    if (numberBinaryDigits[i] == '1')
                    {
                        isOnBoundary = true;
                        if (isInsideNeuron)
                        {
                            isInsideNeuron = false;
                            beenInNeuron = true;
                        } 

                        // Превръщаме границата на 0-ла от 1ца
                        numberBinaryDigits[i] = '0';
                    }
                    else if (numberBinaryDigits[i] == '0')
                    {
                        // Ако вече сме на границата и следващото число не е граница, а е нула
                        // и досега не сме влизали в неврон на този ред
                        if (!beenInNeuron && isOnBoundary)
                        {
                            isInsideNeuron = true;
                            isOnBoundary = false;
                        }

                        // Ако сме вътре в неврона, 0лите стават на 1ци
                        if (isInsideNeuron)
                        {
                            numberBinaryDigits[i] = '1';
                        }
                    }
                }

                // Ако сме на границата но не сме влезли в неврон (т.е целия ред е само граница)
                if (!beenInNeuron)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    uint resultNumber = Convert.ToUInt32(new string(numberBinaryDigits), 2);
                    Console.WriteLine(resultNumber);
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
