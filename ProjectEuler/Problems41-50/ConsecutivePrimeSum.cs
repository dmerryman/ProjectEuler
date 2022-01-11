using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class ConsecutivePrimeSum
    {
        public static int FindConsecutivePrimeSum(int limit)
        {
            // int maxNumTerms = Int32.minvalue to track the number of terms in a sequence.
            // Get a sieve (or list of) for prime numbers from 2 to limit
                // for int i = last prime number under limit to 2
                // int numTerms = 0 to track the number of terms in the sequence
                    // keep adding lower numbers until the total is > limit
                    // if total == limit, check to see if numTerms > maxNumTerms, and change it if it is
                        // when the total is > limit, go down one prime number and repeat.
            // return maxNumTerms
            var maxNumTerms = 0;
            var sumWithMaxNumTerms = Int32.MinValue;
            var primeNumbers = ProjectEuler.SharedCode.Math.GeneratePrimeList(limit: limit).ToArray();
            for (int i = primeNumbers.Length - 1; i >= 0; i--)
            {
                var currNumTerms = 0;
                var currSum = 0;
                if (i < 1)
                {
                    if (maxNumTerms == 0)
                    {
                        sumWithMaxNumTerms = 2;
                    }
                }
                else
                {
                    int indexToSubtract = i - 1;
                    int numToSubtract = primeNumbers[i - 1];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        currSum += primeNumbers[j];
                        currNumTerms++;
                        if (currSum == primeNumbers[i])
                        {
                            // We hit our target.
                            if (currNumTerms > maxNumTerms)
                            {
                                maxNumTerms = currNumTerms;
                                sumWithMaxNumTerms = primeNumbers[i];
                            }

                        }
                        else if (currSum > primeNumbers[i])
                        {
                            // We overshot our target.
                            currSum -= numToSubtract;
                            currNumTerms--;
                            indexToSubtract--;
                            numToSubtract = primeNumbers[indexToSubtract];
                        }
                        // Not enough terms left here.
                    }
                }
                
                
            }

            return sumWithMaxNumTerms;
        }
    }
}
