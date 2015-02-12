using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Poker
    {
        static void Main(string[] args)
        {
            int[] cards = new int[13];            
            string hand = "Nothing";

            // Get cards
            for (int i = 0; i < 5; i++)
            {
                string card = Console.ReadLine();
                if (card == "A") cards[0]++;
                if (card == "2") cards[1]++;
                if (card == "3") cards[2]++;
                if (card == "4") cards[3]++;
                if (card == "5") cards[4]++;
                if (card == "6") cards[5]++;
                if (card == "7") cards[6]++;
                if (card == "8") cards[7]++;
                if (card == "9") cards[8]++;
                if (card == "10") cards[9]++;
                if (card == "J") cards[10]++;
                if (card == "Q") cards[11]++;
                if (card == "K") cards[12]++;
            }
            
            // Check for pairs
            int pairs = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == 2)
                {
                    pairs++;
                }
            }

            //Check hand
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == 5)
                {
                    hand = "Impossible";
                }
                if (cards[i] == 4)
                {
                    hand = "Four of a Kind";
                }
                if (cards[i] == 3)
                {
                    hand = "Three of a Kind";
                }
                if (cards[i] == 2)
                {
                    hand = "One Pair";
                }
                if (pairs == 2)
                {
                    hand = "Two Pairs";
                }
                if (cards[i] == 3 && pairs == 1)
                {
                    hand = "Full House";
                    break;
                }
            }

            // Check the first 9 cards for straight
            for (int i = 0; i <= 8; i++)
            {
                if (cards[i]  == 1 && cards[i + 1] == 1 && cards[i + 2] == 1
                    && cards[i + 3] == 1 && cards[i + 4] == 1)
                {
                    hand = "Straight";
                }
            }

            // Check the last 6 crads (including ACE - card 0) for straight
            if (cards[0] == 1 && cards[9] == 1 && cards[10] == 1 &&
                cards[11] == 1 && cards[12] == 1)
            {
                hand = "Straight";
            }
            Console.WriteLine(hand);
        }
    }

}
