using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class CodedTriangleNumbers
    {
        public static int FindCodedTriangleNumbers()
        {
            // int numberOfTriangleWords = 0 to track number of triangle words.
            // Read the file into memory.
            // Loop through each word in the file, and determine its score.
                // for each score, check to see if it is a triangle number.
                    // if it is, then increment numberOfTriangleWords by 1.
            // return number of triangle words.
            int numberOfTriangleWords = 0;
            string[] words = SharedCode.InputHelper.ReadCSVInputNoQuotes(
                path: @"C:\Users\dmerryman\Documents\repos\ProjectEuler\ProjectEuler\Resources\p042_words.txt");
            List<int> triangleNumbers = GetTriangleNumbers(limit: 28);
            foreach (string word in words)
            {
                int wordScore = CalculateWordScore(word: word);
                if (triangleNumbers.Contains(item: wordScore))
                {
                    numberOfTriangleWords++;
                }
            }

            return numberOfTriangleWords;
        }

        public static List<int> GetTriangleNumbers(int limit)
        {
            List<int> triangleNumbers = new List<int>();
            for (int i = 0; i < limit; i++)
            {
                triangleNumbers.Add(item: GetTriangleNumber(number: i));
            }

            return triangleNumbers;
        }

        public static int CalculateWordScore(string word)
        {
            int score = 0;
            char[] letters = word.ToCharArray();
            foreach (char c in letters)
            {
                score += (int)c - 64;
            }
            return score;
        }

        private static int GetTriangleNumber(int number)
        {
            return ((number + 1) * number) / 2;
        }

    }
}
