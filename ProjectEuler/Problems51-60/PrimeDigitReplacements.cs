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
            // int smallestPrimeReplacement = int32.maxvalue to track the answer.
            // Get a list of prime numbers from 2 to 100,000,000.
            // Loop through the prime numbers.
                // Check each combination of digit replacements for 0 to 9 for the number of primes.
                // If this can give 8 prime numbers, return that prime number.
            var smallesPrimeReplacement = Int32.MaxValue;
            var primeNumbers = ProjectEuler.SharedCode.Math.GeneratePrimeList(limit: 100000000);
            var primeSieve = ProjectEuler.SharedCode.Math.GeneratePrimeSieve(limit: 100000000);
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (CheckForNumberOfReplacementPrimes(primeSieve: primeSieve, targetNumber: targetNumber, testNumber: primeNumbers[i]))
                {
                    Debug.WriteLine("We found a solution here. How to output it?");
                    return primeNumbers[i];
                }
            }
            return smallesPrimeReplacement;
        }

        public static bool CheckForNumberOfReplacementPrimes(bool[] primeSieve, int targetNumber, int testNumber)
        {
            // Loop through each replacement combination.
                // int numPrimeValues = 0 to track the number of prime values for this replacement combination.
                // if numPrimeValues == targetNumber, return true.
            // return false.
            if (testNumber == 120383)
            {
                int pause = 1;
            }
            String testNumberString = testNumber.ToString();
                var possibleNumbers = GetPossibleVariations(input: testNumberString);
                int numberOfPrimes = 0;
                foreach (var possiblePrime in possibleNumbers)
                {
                    if (possiblePrime == "X2X3X3")
                    {
                        int pause2 = 2;
                    }
                    if (GetNumberOfPrimesForReplacement(primeSieve: primeSieve, variation: possiblePrime) ==
                        targetNumber)
                    {
                        Debug.Write("{0} was the variation.", possiblePrime);
                        return true;
                    }
                }
                if (numberOfPrimes == targetNumber)
                {
                    //Debug.WriteLine("Checking {0} with digit {1} gave {2} prime numbers.", testNumber, digit, numberOfPrimes);
                    return true;
                }
                else if (numberOfPrimes > targetNumber)
                {
                    //Debug.WriteLine("Checking {0} with digit {1} gave {2} prime numbers.", testNumber, digit, numberOfPrimes);
                    Debug.WriteLine("Should check to see if this counts.");
                }

                return false;
        }

        public static int GetNumberOfPrimesForReplacement(bool[] primeSieve, string variation)
        {
            int numberOfPrimeValues = 0;
            for (int i = 0; i <= 9; i++)
            {
                int valueToTest = Int32.Parse(variation.Replace(oldChar: 'X', newChar: (char)(i + 48)));
                if (valueToTest.ToString().Length == variation.Length && !primeSieve[valueToTest])
                {
                    numberOfPrimeValues++;
                }
            }
            return numberOfPrimeValues;
        }

        public static HashSet<string> GetPossibleVariations(String input)
        {
            HashSet<string> permutations = new HashSet<string>();
            char[] letters = input.ToCharArray();
            CombinationsHelper(combinations: permutations, letters: letters, k: 0, m: letters.Length - 1);
            //List<int> variations = permutations.Select(s => Int32.TryParse(s, out int n) ? n : (int?)null)
            //    .Where(n => n.HasValue).Select(n => n.Value).ToList();

            //return variations;
            return permutations;
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
