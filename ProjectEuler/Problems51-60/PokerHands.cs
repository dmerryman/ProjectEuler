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
            string p1HighestRelevantCard = String.Empty;
            string p2HighestRelevantCard = String.Empty;
            var p1Score = GetHandRank(hand: p1Hand, ref p1HighestRelevantCard);
            var p2Score = GetHandRank(hand: p2Hand, ref p2HighestRelevantCard);
            if (p1Score > p2Score)
            {
                return true;
            }
            else if (p1Score == p2Score)
            {
                // Tiebreaker.
                int winStatus = ResolveTie(p1HighestRelevantCard: p1HighestRelevantCard,
                    p2HighestRelevantCard: p2HighestRelevantCard);
                if (winStatus == 1)
                {
                    return true;
                }
                else if (winStatus == 0)
                {
                    // investigate further.
                    int lastTieResolveResult = ResolveTieLastAttempt(p1Hand: p1Hand, p2Hand: p2Hand);
                    if (lastTieResolveResult == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (winStatus == -1)
                {
                    // Player 2 wins.
                    return false;
                }
            }

            return p1Win;
        }

        private static int ResolveTieLastAttempt(string[] p1Hand, string[] p2Hand)
        {
            List<int> p1ValueIndexes = new List<int>();
            List<int> p2ValueIndexes = new List<int>();
            foreach (var card in p1Hand)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == card.Substring(startIndex: 0, length: 1))
                    {
                        p1ValueIndexes.Add(item: i);
                        break;
                    }
                }
            }
            foreach (var card in p2Hand)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == card.Substring(startIndex: 0, length: 1))
                    {
                        p2ValueIndexes.Add(item: i);
                        break;
                    }
                }
            }

            p1ValueIndexes.Sort();
            p2ValueIndexes.Sort();

            for (int i = p1ValueIndexes.Count - 1; i >= 0; i--)
            {
                if (p1ValueIndexes[i] > p2ValueIndexes[i])
                {
                    return 1;
                }
                else if (p2ValueIndexes[i] > p1ValueIndexes[i])
                {
                    return -1;
                }
            }

            return 0;
        }

        private static int ResolveTie(string p1HighestRelevantCard, string p2HighestRelevantCard)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                if (values[i] == p1HighestRelevantCard && values[i] == p2HighestRelevantCard)
                {
                    return 0;
                }

                if (values[i] == p1HighestRelevantCard)
                {
                    return 1;
                }

                if (values[i] == p2HighestRelevantCard)
                {
                    return -1;
                }
            }

            throw new Exception("Error in breaking tie.");
        }

        public static int GetHandRank(string[] hand, ref string highestRelevantCard)
        {
            if (IsItARoyalFlush(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 10;
            }

            if (IsItAStraightFlush(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 9;
            }

            if (IsItFourOfAKind(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 8;
            }

            if (IsItAFullHouse(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 7;
            }

            if (IsItAFlush(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 6;
            }

            if (IsItAStraight(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 5;
            }

            if (IsItThreeOfAKind(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 4;
            }

            if (IsItTwoPairs(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 3;
            }

            if (IsItOnePair(hand: hand, highestRelevantCard: ref highestRelevantCard))
            {
                return 2;
            }

            highestRelevantCard = GetHighestValue(relevantCards: hand);
            return 1;
        }

        public static bool IsItOnePair(string[] hand, ref string highestRelevantCard)
        {
            return (GetNumberOfPairs(hand: hand, highestRelevantCard: ref highestRelevantCard) == 1);
        }
        public static bool IsItTwoPairs(string[] hand, ref string highestRelevantCard)
        {
            return (GetNumberOfPairs(hand: hand, highestRelevantCard: ref highestRelevantCard) == 2);
        }

        private static int GetNumberOfPairs(string[] hand, ref string highestRelevantCard)
        {
            Dictionary<string, int> valuesInHand = new Dictionary<string, int>();
            List<string> pairValues = new List<string>();
            int numberOfPairs = 0;
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
                if (value.Value == 2)
                {
                    numberOfPairs++;
                    pairValues.Add(item: value.Key);
                }
            }

            if (pairValues.Count > 0)
            {
                for (int i = values.Length - 1; i >= 0; i--)
                {
                    if (pairValues.Contains(item: values[i]))
                    {
                        highestRelevantCard = values[i];
                        break;
                    }
                }
            }

            return numberOfPairs;
        }

        public static bool IsItThreeOfAKind(string[] hand, ref string highestRelevantCard)
        {
            return (GetHighestNumberOfSameValues(hand: hand, highestRelevantCard: ref highestRelevantCard) == 3);
        }

        public static bool IsItAStraight(string[] hand, ref string highestRelevantCard)
        {
            bool isInIncreasingOrder = IsInIncreasingOrder(hand: hand);
            if (isInIncreasingOrder)
            {
                highestRelevantCard = GetHighestValue(relevantCards: hand);
            }

            return isInIncreasingOrder;
        }

        public static bool IsItAFlush(string[] hand, ref string highestRelevantCard)
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

            if (isItAFlush)
            {
                highestRelevantCard = GetHighestValue(relevantCards: hand);
            }

            return isItAFlush;
        }
        public static bool IsItAFullHouse(string[] hand, ref string highestRelevantCard)
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
                    highestRelevantCard = value.Key;
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
        public static bool IsItFourOfAKind(string[] hand, ref string highestRelevantCard)
        {
            return (GetHighestNumberOfSameValues(hand: hand, highestRelevantCard: ref highestRelevantCard) == 4);
        }

        private static int GetHighestNumberOfSameValues(string[] hand, ref string highestRelevantCard)
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
                    highestRelevantCard = value.Key;
                }
            }

            return highestNumberOfSameValues;
        }

        public static bool IsItARoyalFlush(string[] hand, ref string highestRelevantCard)
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

            if (returnValue)
            {
                highestRelevantCard = GetHighestValue(relevantCards: hand);
            }

            return returnValue;
        }

        public static bool IsItAStraightFlush(string[] hand, ref string highestRelevantCard)
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

            if (returnValue)
            {
                highestRelevantCard = GetHighestValue(relevantCards: hand);
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

        private static string GetHighestValue(string[] relevantCards)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                foreach (var card in relevantCards)
                {
                    if (values[i] == card.Substring(startIndex: 0, length: 1))
                    {
                        return values[i];
                    }
                }
            }

            throw new Exception("Error in getting highest value from hand");
        }
    }
}
