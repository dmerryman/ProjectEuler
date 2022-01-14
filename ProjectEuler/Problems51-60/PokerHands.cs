using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PokerHands
    {
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
            }
            throw new NotImplementedException();
        }

        public static bool DoesPlayer1Win(string[] cards)
        {
            throw new NotImplementedException();
        }
    }
}
