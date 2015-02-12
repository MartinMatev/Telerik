using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main(string[] args)
        {
            // Идеята на задачата е следната: 
            // (1). Подават ни ДЕСЕТИЧНО число в конзолата;
            // (2). Превъщаме го в седмично, както превръщаме двуично в десетично ! Пр.:
            // 10011 = 1*2^0 + 1*2^1 + 0*2^2 + 0*2^3 + 1*2^4 == 19(в десетична) 
            // (3). Намираме кое е следващото ДЕСЕТИЧНО число
            // (4). Превръщаме следващото числото от десетична в седмична бройна система:
            // (5). Делим десетичното число на 7, докато не получим 0, вземаме остатъците от ДОЛУ на ГОРЕ
            // и получаваме еквивалента на десетичното число в седмична бройна система

            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);
            int powerCounter = 0;
            int decimalNumber = 0;

            // Превръщаме даденото седмично в ДЕСЕТИЧНО;
            while (inputNumber != 0)
            {
                int lastNumber = inputNumber % 10;
                decimalNumber += lastNumber * (int)Math.Pow(7, powerCounter);
                powerCounter++;
                inputNumber /= 10;
            }

            // Увеличаваме десетичното с едно
            decimalNumber++;
            string result = "";

            // Превръщаме новото десетично в седмично 
            while (decimalNumber != 0)
            {
                int lastNumber = (decimalNumber % 7);
                result = lastNumber + result;
                decimalNumber /= 7;
            }
            Console.WriteLine(result);
        }
    }
}
