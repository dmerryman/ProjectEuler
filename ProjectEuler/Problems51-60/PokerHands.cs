using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                if (DoesPlayer1Win(p1Hand: p1Cards, p2Hand: p2Cards))
                {
                    numHandsPlayer1Won++;
                }
            }

            return numHandsPlayer1Won;
        }

        public static bool DoesPlayer1Win(string[] p1Hand, string[] p2Hand)
        {
            bool p1Win = false;
            var p1Score = GetHandRank(hand: p1Hand);
            var p2Score = GetHandRank(hand: p2Hand);
            if (p1Score > p2Score)
            {
                return true;
            }
            else if (p1Score == p2Score)
            {
                // Tiebreaker.
            }

            return p1Win;
        }

        public static int GetHandRank(string[] hand)
        {
            if (IsItARoyalFlush(hand: hand))
            {
                return 10;
            }

            if (IsItAStraightFlush(hand: hand))
            {
                return 9;
            }

            if (IsItFourOfAKind(hand: hand))
            {
                return 8;
            }

            if (IsItAFullHouse(hand: hand))
            {
                return 7;
            }

            if (IsItAFlush(hand: hand))
            {
                return 6;
            }

            if (IsItAStraight(hand: hand))
            {
                return 5;
            }

            if (IsItThreeOfAKind(hand: hand))
            {
                return 4;
            }

            if (IsItTwoPairs(hand: hand))
            {
                return 3;
            }

            if (IsItOnePair(hand: hand))
            {
                return 2;
            }

            return 1;
        }

        public static bool IsItOnePair(string[] hand)
        {
            throw new NotImplementedException();
        }
        public static bool IsItTwoPairs(string[] hand)
        {
            throw new NotImplementedException();
        }
        public static bool IsItThreeOfAKind(string[] hand)
        {
            throw new NotImplementedException();
        }

        public static bool IsItAStraight(string[] hand)
        {
            return IsInIncreasingOrder(hand: hand);
        }

        public static bool IsItAFlush(string[] hand)
        {
            bool isItAFlush = false;
            string suit = hand[0].Substring(startIndex: 1, length: 1);
            if (suit == hand[1].Substring(startIndex: 1, length: 1) &&
                suit == hand[2].Substring(startIndex: 1, length: 1) &&
                suit == hand[3].Substring(startIndex: 1, length: 1) &&
                suit == hand[4].Substring(startIndex: 1, length: 1))
            {
                isItAFlush = true;
            }

            return isItAFlush;
        }
        public static bool IsItAFullHouse(string[] hand)
        {
            Dictionary<string, int> valuesInHand = new Dictionary<string, int>();
            bool isItAFullHouse = false;
            bool foundThree = false;
            bool foundPair = false;
            foreach (var card in hand)
            {
                var value = card.Substring(startIndex: 0, length: 1);
                if (!valuesInHand.ContainsKey(key: value))
                {
                    valuesInHand.Add(key: value, value: 1);
                }
                else
                {
                    valuesInHand[value]++;
                }
            }

            foreach (var value in valuesInHand)
            {
                if (value.Value == 3)
                {
                    foundThree = true;
                }
                else if (value.Value == 2)
                {
                    foundPair = true;
                }
            }

            if (foundThree && foundPair)
            {
                isItAFullHouse = true;
            }

            return isItAFullHouse;
        }
        public static bool IsItFourOfAKind(string[] hand)
        {
            //Dictionary<string, int> valuesInHand = new Dictionary<string, int>();
            //bool isItFourOfAKind = false;
            //foreach (var card in hand)
            //{
            //    var value = card.Substring(startIndex: 0, length: 1);
            //    if (!valuesInHand.ContainsKey(key: value))
            //    {
            //        valuesInHand.Add(key: value, value: 1);
            //    }
            //    else
            //    {
            //        valuesInHand[value]++;
            //    }
            //}

            //foreach (var value in valuesInHand)
            //{
            //    if (value.Value == 4)
            //    {
            //        isItFourOfAKind = true;
            //    }
            //}

            //return isItFourOfAKind;

            return (GetHighestNumberOfSameValues(hand: hand) == 4);
        }

        private static int GetHighestNumberOfSameValues(string[] hand)
        {
            Dictionary<string, int> valuesInHand = new Dictionary<string, int>();
            int highestNumberOfSameValues = 0;
            foreach (var card in hand)
            {
                var value = card.Substring(startIndex: 0, length: 1);
                if (!valuesInHand.ContainsKey(key: value))
                {
                    valuesInHand.Add(key: value, value: 1);
                }
                else
                {
                    valuesInHand[value]++;
                }
            }

            foreach (var value in valuesInHand)
            {
                if (value.Value > highestNumberOfSameValues)
                {
                    highestNumberOfSameValues = value.Value;
                }
            }

            return highestNumberOfSameValues;
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
                returnValue = IsInIncreasingOrder(hand: hand);
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

        public static bool IsInIncreasingOrder(string[] hand)
        {
            bool increasingOrder = false;
            HashSet<string> uniqueValuesInHand = new HashSet<string>();
            int numUniqueValuesInHand = 0;
            foreach (var card in hand)
            {
                if (uniqueValuesInHand.Add(item: card.Substring(startIndex: 0, length: 1)))
                {
                    numUniqueValuesInHand++;
                }
            }

            if (numUniqueValuesInHand == 5)
            {
                string[] valuesAltered = new string[values.Length + 4];
                for (int i = 0; i < values.Length; i++)
                {
                    valuesAltered[i] = values[i];
                }

                for (int i = 0; i < 4; i++)
                {
                    valuesAltered[values.Length + i] = values[i];
                }

                int numConsecutive = 0;
                for (int i = 0; i < valuesAltered.Length && numConsecutive < 5; i++)
                {
                    if (uniqueValuesInHand.Contains(item: valuesAltered[i]))
                    {
                        numConsecutive++;
                    }
                    else
                    {
                        numConsecutive = 0;
                    }
                }

                if (numConsecutive == 5)
                {
                    increasingOrder = true;
                }
            }

            return increasingOrder;
        }

        //public static bool IsInIncreasingOrder(string[] hand, string lowestValue)
        //{
        //    bool isItInIncreasingOrder = true;
        //    int lowestValueIndex = -1;
        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        if (values[i] == lowestValue)
        //        {
        //            lowestValueIndex = i;
        //            break;
        //        }
        //    }

        //    if (lowestValueIndex == 0)
        //    {
        //        HashSet<string> valuesFromHand = new HashSet<string>();
        //        for (int i = 0; i < hand.Length; i++)
        //        {
        //            if (!valuesFromHand.Add(item: hand[i].Substring(startIndex: 0, length: 1)))
        //            {
        //                isItInIncreasingOrder = false;
        //            }
        //        }

        //        int highestLowIndex = -1;
        //        for (int i = 0; i < 5; i++)
        //        {
        //            if (valuesFromHand.Contains(values[i]))
        //            {
        //                highestLowIndex = i;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }

        //        int numRemaining = 4 - highestLowIndex;
        //        for (int i = 0; i < numRemaining; i++)
        //        {
        //            if (valuesFromHand.Add(item: values[values.Length - 1 - i]))
        //            {
        //                isItInIncreasingOrder = false;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        HashSet<string> valuesRequired = new HashSet<string>();
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Debug.WriteLine("Adding item from values[{0}] to valuesRequired Array.", lowestValueIndex + i);
        //            valuesRequired.Add(item: values[lowestValueIndex + i]);
        //        }

        //        for (int i = 0; i < hand.Length; i++)
        //        {
        //            if (valuesRequired.Add(item: hand[i].Substring(startIndex: 0, length: 1)))
        //            {
        //                isItInIncreasingOrder = false;
        //            }
        //        }
        //    }

        //    return isItInIncreasingOrder;
        //}

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
