using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PokerHands
    {
        public static string[] values = new string[]{"2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K", "A"};
        public static string[] suits = new string[] { "H", "C", "S", "D" };
        public static int FindPokerHands()
        {
            // Read in the input file into an array.
            // For each string line in the array.
                // Split line on whitespace into an array of strings. Player 1 is the first 5 cards, and Player 2 is the last 5 cards.
                    // Check to see which player wins.
                        // If Player 1 wins, increment numHandsPlayer1Won by one.
            // return  numHandsPlayer1Won.
            var games = SharedCode.InputHelper.ReadInput(
                path: @"C:\Users\dmerryman\Documents\repos\ProjectEuler\ProjectEuler\Resources\p054_poker.txt");
            int numHandsPlayer1Won = 0;
            foreach (var game in games)
            {
                var cards = game.Split();
                var p1Cards = new string[]{ cards[0], cards[1], cards[2], cards[3], cards[4] };
                var p2Cards = new string[] { cards[5], cards[6], cards[7], cards[8], cards[9] };
            }
            throw new NotImplementedException();
        }

        public static bool DoesPlayer1Win(string[] cards)
        {
            throw new NotImplementedException();
        }

        public static bool IsItAStraightFlush(string[] hand)
        {
            bool returnValue = true;
            string suit = hand[0].Substring(1, 1);
            foreach (var card in hand)
            {
                if (!(suit == hand[1].Substring(1, 1) && suit == hand[2].Substring(1, 1) &&
                    suit == hand[3].Substring(1, 1) && suit == hand[4].Substring(1, 1)))
                {
                    returnValue = false;
                }
            }

            if (returnValue)
            {

            }
            return returnValue;
        }

        public static string GetLowestValue(string[] hand)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (hand[0].Substring(0, 1) == values[i] || hand[1].Substring(0, 1) == values[i] ||
                    hand[2].Substring(0, 1) == values[i] || hand[3].Substring(0, 1) == values[i] ||
                    hand[4].Substring(0, 1) == values[i])
                {
                    return values[i];
                }
            }

            throw new Exception("Card not found");
        }
    }
}
