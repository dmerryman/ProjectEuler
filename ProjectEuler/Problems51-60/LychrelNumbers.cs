using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler.Problems51_60
{
    public static class LychrelNumbers
    {
        public static int FindLychrelNumbers(int numIterations, int limit)
        {
            // int numLychrelNumbers = 0 to track the number of lychrel numbers.
            // for int currNum = 1 to 9999
                // Determine if currNum can be made into a Lychrel Number in less than numIterations iterations.
                    // if it can be, incrememt numLychrelNumbers by one.
            // return numLychrelNumbers.
            int numLychrelNumbers = 0;
            for (int currNum = 1; currNum < limit; currNum++)
            {
                //Debug.WriteLine("Checking {0}. We currently have {1} Lychrel numbers.", currNum, numLychrelNumbers);
                if (IsItALychrelNumber(testNumber: currNum, numIterations: numIterations))
                {
                    numLychrelNumbers++;
                }
            }

            return numLychrelNumbers;
        }

        public static bool IsItALychrelNumber(long testNumber, int numIterations)
        {
            // for int i = 0 to numIterations
                // Check to see if adding the number reversed makes a palindrome.
                    // If it does, return false.
            // return true.
            BigInteger currValueToBeTested = new BigInteger(testNumber);
            for (int i = 0; i < numIterations; i++)
            {
                var reversedNumber = SharedCode.Math.ReverseNumber(number: currValueToBeTested);
                currValueToBeTested += reversedNumber;
                if (SharedCode.Math.IsItAPalindrome(value: currValueToBeTested))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
