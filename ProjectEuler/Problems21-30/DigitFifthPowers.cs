using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class DigitFifthPowers
    {
        public static int FindDigitFifthPowers()
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
                List<int> digits = GetDigits(testValue: testValue);
            }
            throw new NotImplementedException();
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
    }
}
