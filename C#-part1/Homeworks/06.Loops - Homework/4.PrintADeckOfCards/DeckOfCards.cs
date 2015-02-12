using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
* The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
* The card faces should start from 2 to A.
* Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
* Use 2 nested for-loops and a switch-case statement.
 */ 
namespace _4.PrintADeckOfCards
{
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            string[] cardFace = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string[] cardSuits = { "spades", "clubs", "hearts", "diamonds" };

            for (int i = 0; i <= cardFace.Length - 1; i++)
            {
                for (int j = 0; j <= cardSuits.Length - 1; j++)
                {
                    Console.Write("{0} of {1}, ", cardFace[i], cardSuits[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
