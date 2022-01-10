using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class PrimePermutations
    {
        public static string FindPrimePermutations()
        {
            // Get a sieve for 4 digit prime numbers.
            // Loop through every prime in sieve.
                // Get all permutations of the prime.
                    // check to see if any 3 of the permutations meet the requirement (all prime, same interval between them.
            string returnValue = string.Empty;
            bool[] primeSieve = ProjectEuler.SharedCode.Math.GeneratePrimeSieve(limit: 10000);
            int numCase = 0;
            for (int testValue = 1001; testValue < primeSieve.Length; testValue += 2)
            {
                if (!primeSieve[testValue])
                {
                    // This is prime.
                    int[] primePermutations = GetPrimePermutations(primeNumber: testValue, primeSieve: primeSieve).OrderBy(s =>s).ToArray();
                    if (primePermutations.Length > 2)
                    {
                        for (int i = 0; i < primePermutations.Length - 1; i++)
                        {
                            for (int j = i + 1; j < primePermutations.Length; j++)
                            {
                                if (primePermutations[i] - testValue == primePermutations[j] - primePermutations[i])
                                {
                                    if (numCase != 1)
                                    {
                                        numCase++;
                                    }
                                    else
                                    {
                                        returnValue = string.Empty + testValue + primePermutations[i] + primePermutations[j];
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }

        private static HashSet<int> GetPrimePermutations(int primeNumber, bool[] primeSieve)
        {
            String testValueString = primeNumber.ToString();
            HashSet<int> primePermutations = new HashSet<int>();
            List<String> permutations = SharedCode.Strings.GetPermutations(value: testValueString);
            foreach (String permutation in permutations)
            {
                int testValue = Int32.Parse(permutation);
                if (testValue.ToString().Length == 4 && !primeSieve[testValue])
                {
                    primePermutations.Add(item: testValue);
                }
            }
            return primePermutations;
        }
    }
}
