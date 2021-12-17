using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class SubstringDivisibility
    {
        public static int FindSubstringDivisibility()
        {
            // int sumOfSubstringDivisibleNumbers = 0 to track the sum of substring divisible numbers
            // Loop for int testValue from 123456789 to 987654321
                // Check to see if the number is pandigital.
                    // if it is, then check to see if its substring divisible.
                        // if is, then add that value to sumOfSubstringDivisibleNumbers
            // return sumOfSubstringDivisibleNumbers
            throw new NotImplementedException();
        }

        public static bool IsItSubstringDivisible(int testValue)
        {
            int[] divisors = new int[] {2, 3, 5, 7, 11, 13, 17 };
            // foreach digit d2 - d10
                // check to see if d2d3d4 is divisible by the appropriate number.
                    // if it isn't, return false.
            // return true.
            throw new NotImplementedException();
        }

        public static int GetSubstring(int number, int startDigit, int endDigit)
        {
            int returnNumber = number % (int)Math.Pow(x: 10, y: 11 - startDigit);
            returnNumber /= (int)Math.Pow(x: 10, y: 10 - endDigit);
            return returnNumber;
        }
    }
}
