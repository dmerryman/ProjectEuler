using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class SubstringDivisibility
    {
        public static long FindSubstringDivisibilitySlow()
        {
            // int sumOfSubstringDivisibleNumbers = 0 to track the sum of substring divisible numbers
            // Loop for int testValue from 123456789 to 987654321
                // Check to see if the number is pandigital.
                    // if it is, then check to see if its substring divisible.
                        // if is, then add that value to sumOfSubstringDivisibleNumbers
            // return sumOfSubstringDivisibleNumbers
            long sumOfSubstringDivisibleNumbers = 0;
            for (long testValue = 1023456789; testValue <= 9876543210; testValue++)
            {
                if (SharedCode.Math.GetDigitAtIndex(number: testValue, digit: 4) % 2 == 0 &&
                    SharedCode.Math.GetDigitAtIndex(number: testValue, digit: 6) == 5)

                {
                    if (IsItPandigital(number: testValue))
                    {
                        if (IsItSubstringDivisible(testValue: testValue))
                        {
                            sumOfSubstringDivisibleNumbers += testValue;
                            Debug.WriteLine("Adding {0} gives us {1}", testValue, sumOfSubstringDivisibleNumbers);
                        }
                    }
                }
            }

            return sumOfSubstringDivisibleNumbers;
        }

        public static long FindSubstringDivisibilityPermutations()
        {
            long sumOfSubstringDivisibleNumbers = 0;
            List<string> permutations = GetPermutations(number: 1234567890);
            foreach (string permutation in permutations)
            {
                long valueToCheck = long.Parse(permutation);
                if (SharedCode.Math.GetDigitAtIndex(number: valueToCheck, digit: 4) % 2 == 0 &&
                    SharedCode.Math.GetDigitAtIndex(number: valueToCheck, digit: 6) == 5)
                {
                    if (IsItPandigital(number: valueToCheck))
                    {
                        if (IsItSubstringDivisible(testValue: valueToCheck))
                        {
                            sumOfSubstringDivisibleNumbers += valueToCheck;
                            //Debug.WriteLine("Adding {0} gives us {1}", valueToCheck, sumOfSubstringDivisibleNumbers);
                        }
                    }
                }
            }

            return sumOfSubstringDivisibleNumbers;
        }

        public static bool IsItSubstringDivisible(long testValue)
        {
            // foreach digit d2 - d10
                // check to see if d2d3d4 is divisible by the appropriate number.
                    // if it isn't, return false.
            // return true.
            int[] divisors = new int[] { 2, 3, 5, 7, 11, 13, 17 };
            int numToDivideBy = 0;
            for (int i = 2; i < 9; i++)
            {
                long numberToCheck = GetSubstring(number: testValue, startDigit: i, endDigit: i + 2);
                if (numberToCheck % divisors[numToDivideBy] != 0)
                {
                    return false;
                }

                numToDivideBy++;
            }

            return true;
        }

        public static long GetSubstring(long number, int startDigit, int endDigit)
        {
            long numberOfDigits = SharedCode.Math.GetNumberOfDigits(value: number);
            long returnNumber = number % (int)Math.Pow(x: 10, y: numberOfDigits + 1 - startDigit);
            returnNumber /= (long)Math.Pow(x: 10, y: numberOfDigits - endDigit);
            return returnNumber;
        }

        public static bool IsItPandigital(long number)
        {
            HashSet<int> digitsAccountedFor = new HashSet<int>();
            while (number > 0)
            {
                int digitToAdd = (int)(number % 10);
                if (digitsAccountedFor.Contains(item: digitToAdd))
                {
                    return false;
                }

                digitsAccountedFor.Add(digitToAdd);
                number /= 10;
            }
            for (int i = 0; i < digitsAccountedFor.Count; i++)
            {
                if (!digitsAccountedFor.Contains(item: i))
                {
                    return false;
                }
            }

            return true;
        }

        public static List<String> GetPermutations(int number)
        {
            String numberString = number.ToString();
            int numberOfDigits = numberString.Length;
            List<String> permutations = new List<string>();
            GetPermutationsHelper(permutations: permutations, numberString, l: 0, r: numberOfDigits - 1);
            return permutations;
        }

        private static void GetPermutationsHelper(List<String> permutations, String str, int l, int r)
        {
            if (l == r)
            {
                permutations.Add(item: str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str: str, i: l, j: i);
                    GetPermutationsHelper(permutations: permutations, str: str, l: l + 1, r);
                    str = swap(str: str, i: l, j: i);
                }
            }
        }

        private static String swap(String str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            String s = new String(charArray);
            return s;
        }
    }
}
