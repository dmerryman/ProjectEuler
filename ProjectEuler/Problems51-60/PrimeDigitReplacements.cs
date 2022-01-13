using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PrimeDigitReplacements
    {
        public static int FindPrimeDigitReplacements(int targetNumber)
        {
            // Get a list of prime numbers from 0 up to a guess for the limit.
            // Get a sieve of prime numbers.
            // Loop through the list of prime numbers.
                // For each prime number, check if we get a prime number that matches our criteria.
                // Return that number if it exists.
                var primeNumbers = ProjectEuler.SharedCode.Math.GeneratePrimeList(limit: 100000000);
            var primeSieve = ProjectEuler.SharedCode.Math.GeneratePrimeSieve(limit: 100000000);
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                int? smallestReplacementPrime = CheckForSmallestReplacementPrimes(primeSieve: primeSieve,
                    targetNumber: targetNumber, testNumber: primeNumbers[i]);
                if (smallestReplacementPrime.HasValue)
                {
                    return smallestReplacementPrime.Value;
                }
                
            }

            throw new Exception();
        }

        public static int? CheckForSmallestReplacementPrimes(bool[] primeSieve, int targetNumber, int testNumber)
        {
            // For the given prime number, get a list of possible replacements. 'X' indicates a character that will be replaced.
            // For each replacement combination, get a count of the number of primes created from replacing X with 1-9.
            // If the number of primes you get from replacing X with 1-9 is == targetNumber, then we need to return the smallest prime in that list.
            String testNumberString = testNumber.ToString();
                var possibleNumbers = GetPossibleVariations(input: testNumberString);
                foreach (var possiblePrime in possibleNumbers)
                {
                    List<int> primeReplacements =
                        GetPrimesForReplacement(primeSieve: primeSieve, variation: possiblePrime);
                    if (primeReplacements.Count ==
                        targetNumber)
                    {
                        Debug.Write("{0} was the variation.", possiblePrime);
                        return primeReplacements.First();
                    }
                }

                return null;
        }

        public static List<int> GetPrimesForReplacement(bool[] primeSieve, string variation)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
                int valueToTest = Int32.Parse(variation.Replace(oldChar: 'X', newChar: (char)(i + 48)));
                if (valueToTest.ToString().Length == variation.Length && !primeSieve[valueToTest])
                {
                    primes.Add(item: valueToTest);
                }
            }
            return primes;
        }

        public static HashSet<string> GetPossibleVariations(String input)
        {
            HashSet<string> variations = new HashSet<string>();
            char[] letters = input.ToCharArray();
            CombinationsHelper(combinations: variations, letters: letters, k: 0, m: letters.Length - 1);
            return variations;
        }

        public static void CombinationsHelper(HashSet<string> combinations, char[] letters, int k, int m)
        {
            if (k > m)
            {
                combinations.Add(new string(letters));
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    char temp = letters[k];
                    letters[k] = 'X';
                    CombinationsHelper(combinations: combinations, letters: letters, k: k + 1, m: m);
                    letters[k] = temp;
                    CombinationsHelper(combinations: combinations, letters: letters, k: k + 1, m: m);
                }
            }
        }
    }
}
