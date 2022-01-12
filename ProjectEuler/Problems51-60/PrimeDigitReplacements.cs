using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PrimeDigitReplacements
    {
        public static int FindPrimeDigitReplacements(int targetNumber)
        {
            // int smallestPrimeReplacement = int32.maxvalue to track the answer.
            // Get a list of prime numbers from 2 to 100,000,000.
            // Loop through the prime numbers.
                // Check each combination of digit replacements for 0 to 9 for the number of primes.
                // If this can give 8 prime numbers, return that prime number.
            var smallesPrimeReplacement = Int32.MaxValue;
            var primeNumbers = ProjectEuler.SharedCode.Math.GeneratePrimeList(limit: 100000000);
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (CheckForNumberOfReplacementPrimes(targetNumber: targetNumber, primeNumber: primeNumbers[i]))
                {

                }
            }
            return smallesPrimeReplacement;
        }

        public static bool CheckForNumberOfReplacementPrimes(int targetNumber, int primeNumber)
        {
            // Loop through each replacement combination.
                // int numPrimeValues = 0 to track the number of prime values for this replacement combination.
                // if numPrimeValues == targetNumber, return true.
            // return false.
            throw new NotImplementedException();
        }
    }
}
