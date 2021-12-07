using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class DigitFifthPowers
    {
        public static int FindDigitFifthPowersBasic()
        {
            // Initialize sumOfDigitFifthPowers to 0.
            // Loop for testValue from 32 to 354294
            // for each testValue, get the individual digits, and check to see if the sum of each
            // individual digit raised to the power of 5 is equal to testValue.
            // If it is, add that number to sumOfDigitFifthPowers.
            // return sumOfDigitFifthPowers.
            int sumOfDigitFifthPowers = 0;
            for (int testValue = 32; testValue <= 354294; testValue++)
            {
                if (testValue == 4150)
                {
                    int pause = 1;
                }
                List<int> digits = GetDigits(testValue: testValue);
                if (CanBeWrittenAsSumOfFifthPowers(testValue: testValue, digits: digits, power: 5))
                {
                    sumOfDigitFifthPowers += testValue;
                }
            }

            return sumOfDigitFifthPowers;
        }

        public static int FindDigitFifthPowersBetter(int power)
        {
            Dictionary<int, int> powersDictionary = FindPowerDigits(power: power);
            int upperLimit = GetUpperLimit(power: power);
            int sumOfDigitFifthPowers = 0;
            for (int testValue = 121; testValue <= upperLimit; testValue++)
            {
                if (testValue == 4150)
                {
                    int pause = 1;
                }
                List<int> digits = GetDigits(testValue: testValue);
                if (CanBeWrittenAsSumOfFifthPowersBetter(testValue: testValue, digits: digits,
                        powersDictionary: powersDictionary))
                {
                    sumOfDigitFifthPowers += testValue;
                }
            }

            return sumOfDigitFifthPowers;
        }

        private static int GetUpperLimit(int power)
        {
            int numDigits = 1;
            bool increased = true;
            int newSum = 0;
            while (increased)
            {
                newSum = 0;
                for (int i = 1; i <= numDigits; i++)
                {
                    newSum += (int)Math.Pow(x: 9, y: power);
                    int newNumDigits = newSum.ToString().Length;
                    if (newNumDigits == numDigits)
                    {
                        increased = false;
                    }

                    numDigits = newNumDigits;
                }
            }

            return newSum;
        }

        private static bool CanBeWrittenAsSumOfFifthPowersBetter(int testValue, List<int> digits,
            Dictionary<int, int> powersDictionary)
        {
            int currSum = 0;
            foreach (int i in digits)
            {
                currSum += powersDictionary[i];
            }

            return currSum == testValue;
        }

        private static Dictionary<int, int> FindPowerDigits(int power)
        {
            Dictionary<int, int> powersDictionary = new Dictionary<int, int>();
            for (int i = 2; i <= 9; i++)
            {
                powersDictionary.Add(key: i, value: (int)Math.Pow(x: i, y: power));
            }
            powersDictionary.Add(key: 0, value: 0);
            powersDictionary.Add(key: 1, value: 1);
            return powersDictionary;
        }

        private static List<int> GetDigits(int testValue)
        {
            // Initialize a new List to store the digits.
            // Loop until testValue is 0.
            // Store mod 10 as a digit, and then divide testValue by 10.
            List<int> digits = new List<int>();
            while (testValue > 0)
            {
                int digitToAdd = testValue % 10;
                digits.Add(item: digitToAdd);
                testValue /= 10;
            }

            return digits;
        }

        private static bool CanBeWrittenAsSumOfFifthPowers(int testValue, List<int> digits, int power)
        {
            int currSum = 0;
            foreach (int i in digits)
            {
                currSum += (int)Math.Pow(x: i, y: power);

            }

            return currSum == testValue;
        }
    }
}
