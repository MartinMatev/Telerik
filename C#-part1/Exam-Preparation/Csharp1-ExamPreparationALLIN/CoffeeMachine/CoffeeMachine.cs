using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            List<decimal> trayMoney = new List<decimal>();
            for (int i = 0; i <= 4; i++)
            {
                trayMoney.Add(decimal.Parse(Console.ReadLine()));
            }
            decimal inputMoney = decimal.Parse(Console.ReadLine());
            decimal drinkPrice = decimal.Parse(Console.ReadLine());
            int trayMoneyLenght = trayMoney.Count;
            decimal traySum = 0;
            bool enoughMoney = false;
            bool notEnoughChange = false;

            trayMoney[0] *= 0.05m;
            trayMoney[1] *= 0.10m;
            trayMoney[2] *= 0.20m;
            trayMoney[3] *= 0.50m;
            trayMoney[4] *= 1.00m;

            for (int i = 0; i < trayMoneyLenght; i++)
            {
                traySum += trayMoney[i];

                if (traySum + drinkPrice >= inputMoney && inputMoney >= drinkPrice)
                {
                    enoughMoney = true;
                }
            }

            if (traySum < (inputMoney - drinkPrice))
            {
                notEnoughChange = true;
            }


            if (drinkPrice > inputMoney)
            {
                Console.WriteLine("More {0:F2}", drinkPrice - inputMoney);
            }
            else if (enoughMoney && !notEnoughChange)
            {
                Console.WriteLine("Yes {0:F2}", traySum - inputMoney + drinkPrice);
            }
            else if (inputMoney >= drinkPrice && notEnoughChange)
            {
                Console.WriteLine("No {0:F2}", (inputMoney - drinkPrice) - traySum);
            }
        }
    }
}
