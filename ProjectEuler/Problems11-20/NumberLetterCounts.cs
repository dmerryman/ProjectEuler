using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems11_20
{
    public static class NumberLetterCounts
    {
        private static string connectorWord = "and";
        private static string hundredWord = "hundred";
        private static string thousandWord = "thousand";

        private static string[] ones = new string[]
            { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static string[] teens =
        {
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static string[] tens =
        {
            "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        public static int FindNumberLetterCounts(int ceiling)
        {
            // loop through N from 1 to ceiling.
            // Set a variable to track the total sum of the letter counts
            // for each N, calculate the sum of the letter counts, and add it to the total sum.
            int totalNumberOfLetters = 0;
            for (int i = 1; i <= ceiling; i++)
            {
                totalNumberOfLetters += GetNumberOfLettersInValue(value: i);
            }

            return totalNumberOfLetters;
        }

        public static int GetNumberOfLettersInValue(int value)
        {
            // Cases to consider
            // even thousand
            // even hundred
            // even tens
            // last is a teen
            // last single digit
            int numberOfLetters = 0;
            if (value > 999 && value <= 1000)
            {
                numberOfLetters += ones[0].Length + thousandWord.Length;
            }

            if (value > 99)
            {
                if (value % 1000 != 0)
                {
                    numberOfLetters += ones[(value / 100) - 1].Length;
                    numberOfLetters += hundredWord.Length;
                    if (value % 100 != 0)
                    {
                        numberOfLetters += connectorWord.Length;
                    }
                }
            }

            if (value % 100 > 19 || value % 100 == 10) // add || value % 100 == 10?
            {
                if (value % 100 != 0)
                {
                    int thisTens = value % 100 / 10;
                    numberOfLetters += tens[thisTens - 1].Length;
                }
            }

            if (value % 100 > 10 && value % 100 < 20)
            {
                numberOfLetters += teens[(value % 10) - 1].Length;
            }

            else if (value % 10 != 0)
            {
                int thisOnes = value % 10;
                numberOfLetters += ones[thisOnes - 1].Length;
            }
            return numberOfLetters;
        }

        

    }
}
