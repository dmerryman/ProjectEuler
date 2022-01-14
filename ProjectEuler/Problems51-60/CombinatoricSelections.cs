using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class CombinatoricSelections
    {
        public static int FindCombinatoricSelections()
        {
            // int numCombinationsExceeding1Mil = 0 to track the number of combinations greater than 1 million.
            // for (int n = 1 to 100)
                // for (int r = 0 to n)
                    // Find the number of distinct values for this combination.
                        // If it is, incrememnt numCombinationsExceeding1Mil by 1.
            // return numCombinationsExceeding1Mil.
            int numCombinationsExceeding1Mil = 0;
            for (int n = 1; n <= 100; n++)
            {
                for (int r = 0; r < n; r++)
                {
                    BigInteger numberOfCombinations = CalculateNumberOfCombinations(n: n, r: r);
                    if (numberOfCombinations > 1000000)
                    {
                        numCombinationsExceeding1Mil++;
                    }
                }
            }

            return numCombinationsExceeding1Mil;
        }

        public static int FindCombinatoricSelectionsFaster()
        {
            int numCombinationsExceecding1Mil = 0;
            BigInteger[] factorials = new BigInteger[101];
            for (int i = 0; i <= 100; i++)
            {
                factorials[i] = CalculateFactorial(n: i);
            }
            for (int n = 1; n <= 100; n++)
            {
                for (int r = 0; r < n; r++)
                {
                    {
                        BigInteger numberOfCombinations = factorials[n] / (factorials[r] * factorials[n - r]);
                        if (numberOfCombinations > 1000000)
                        {
                            numCombinationsExceecding1Mil++;
                        }
                    }
                }
            }

            return numCombinationsExceecding1Mil;
        }

        public static BigInteger CalculateNumberOfCombinations(int n, int r)
        {
            BigInteger returnValue = (CalculateFactorial(n: n) / (CalculateFactorial(n: r) * (CalculateFactorial(n: n - r))));
            return returnValue;
        }

        private static BigInteger CalculateFactorial(int n)
        {
            BigInteger result = new BigInteger(1);
            for (int i = n; i >= 1; i--)
            {
                result = BigInteger.Multiply(left: result, right: i);
            }

            return result;
        }
    }
}
