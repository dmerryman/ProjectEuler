using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PokerHands
    {
        public static string[] values = new string[]{"2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"};
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

        public static bool IsItARoyalFlush(string[] hand)
        {
            bool returnValue = false;
            if (IsItAllSameSuit(hand: hand))
            {
                returnValue = true;
            }

            if (returnValue)
            {
                HashSet<string> requiredCards = new HashSet<string>() { values[8], values[9], values[10], values[11], values[12] };
                for (int i = 0; i < hand.Length; i++)
                {
                    if (requiredCards.Add(item: hand[i].Substring(startIndex: 0, length: 1)))
                    {
                        returnValue = false;
                    }
                }
            }

            return returnValue;
        }

        public static bool IsItAStraightFlush(string[] hand)
        {
            bool returnValue = false;
            string suit = hand[0].Substring(1, 1);
            if (IsItAllSameSuit(hand: hand))
            {
                returnValue = true;
            }

            if (returnValue)
            {
                string lowestValueCard = GetLowestValue(hand: hand);
                returnValue = IsInIncreasingOrder(hand: hand, lowestValue: lowestValueCard);
            }
            return returnValue;
        }

        public static bool IsItAllSameSuit(string[] hand)
        {
            bool allSameSuit = false;
            string suit = hand[0].Substring(startIndex: 1, length: 1);
            if ((suit == hand[1].Substring(1, 1) && suit == hand[2].Substring(1, 1) &&
                 suit == hand[3].Substring(1, 1) && suit == hand[4].Substring(1, 1)))
            {
                allSameSuit = true;
            }

            return allSameSuit;
        }

        public static bool IsInIncreasingOrder(string[] hand, string lowestValue)
        {
            bool isItInIncreasingOrder = true;
            int lowestValueIndex = -1;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == lowestValue)
                {
                    lowestValueIndex = i;
                    break;
                }
            }

            if (lowestValueIndex == 0)
            {
                HashSet<string> valuesFromHand = new HashSet<string>();
                for (int i = 0; i < hand.Length; i++)
                {
                    if (!valuesFromHand.Add(item: hand[i].Substring(startIndex: 0, length: 1)))
                    {
                        isItInIncreasingOrder = false;
                    }
                }

                int highestLowIndex = -1;
                for (int i = 0; i < 4; i++)
                {
                    if (valuesFromHand.Contains(values[i]))
                    {
                        highestLowIndex = i;
                    }
                    else
                    {
                        break;
                    }
                }

                int numRemaining = 4 - highestLowIndex;
                for (int i = 0; i < numRemaining; i++)
                {
                    if (valuesFromHand.Add(item: values[values.Length - 1 - i]))
                    {
                        isItInIncreasingOrder = false;
                    }
                }

            }
            else
            {
                HashSet<string> valuesRequired = new HashSet<string>();
                for (int i = 0; i < 5; i++)
                {
                    valuesRequired.Add(item: values[lowestValueIndex + i]);
                }

                for (int i = 0; i < hand.Length; i++)
                {
                    if (valuesRequired.Add(item: hand[i].Substring(startIndex: 0, length: 1)))
                    {
                        isItInIncreasingOrder = false;
                    }
                }
            }

            return isItInIncreasingOrder;
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
