using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PrimePairSets
    {
        public static int FindPrimePairSets(int numberOfPrimes)
        {
            // int lowestSumOfPrimePairs = int32.maxvalue to track the lowest sum of prime pairs.
            // Dictionary<int, List<int>> hold a set of prime numbers as the key, and for each key, a list of other prime numbers that
            //  they form a pair with.
            // Get a prime number sieve.
            // Get a list of prime numbers.
            // for each prime1 in prime number list
                // for each prime2 in primenumber list.
                    // Check to see if these 2 prime numbers are a pair.
                        // If they are, then set prime1 as a key in primePairs with prime2 as a new value in a list..
            // primePairs now has each prime number that has at least 1 pair, and a list of the prime numbers they form a pair with.
            // Go through the dictionary, and remove each entry that has a count less than numberOfPrimes.
            // go through primepairs again looking for 3's, 4's, 5's etc until you reach numberOfPrimes.
            // return lowestSumOfPrimePairs
            int lowestSumOfPrimePairs = Int32.MaxValue;
            bool[] primeSieve = SharedCode.Math.GeneratePrimeSieve(limit: 10000000);
            List<int> primeNumbers = SharedCode.Math.GeneratePrimeList(limit: 10000);
            Dictionary<int, List<int>> primePairs = new Dictionary<int, List<int>>();
            List<int> values = new List<int>();

            foreach (int primeNum1 in primeNumbers)
            {
                foreach (int primeNum2 in primeNumbers)
                {
                    if (primeNum1 != primeNum2)
                    {
                        if (CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNum1, prime2: primeNum2))
                        {
                            AddToDictionary(dictionary: primePairs, originalPrimeNumber: primeNum1,
                                addedPrimeNumber: primeNum2);
                        }
                    }
                }
            }

            primePairs = TrimTheImpossibleOnes(dictionary: primePairs, primeSieve: primeSieve, numPrimes: numberOfPrimes);
            primePairs = TrimSome(dictionary: primePairs, primeSieve: primeSieve);
            TrimTheImpossibleOnes(dictionary: primePairs, primeSieve: primeSieve, numPrimes: numberOfPrimes);
            primePairs = TrimSomeMore(dictionary: primePairs, primeSieve: primeSieve);
            TrimTheImpossibleOnes(dictionary: primePairs, primeSieve: primeSieve, numPrimes: numberOfPrimes);

            int[] keysArray = primePairs.Keys.ToArray();
            for (int i = 0; i < keysArray.Length; i++)
            {
                int[] valuesArray = primePairs[keysArray[i]].ToArray();
                for (int j = 0; j < valuesArray.Length - 3; j++)
                {
                    for (int k = j + 1; k < valuesArray.Length - 2; k++)
                    {
                        for (int l = j + 1; l < valuesArray.Length - 1; l++)
                        {
                            for (int m = l + 1; m < valuesArray.Length; m++)
                            {
                                if (CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[j],
                                        prime2: valuesArray[k]) &&
                                    CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[j],
                                        prime2: valuesArray[l]) &&
                                    CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[j],
                                        prime2: valuesArray[m]) &&
                                    CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[k],
                                        prime2: valuesArray[l]) &&
                                    CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[k],
                                        prime2: valuesArray[m]) &&
                                    CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[l],
                                        prime2: valuesArray[m]))
                                {
                                    Debug.WriteLine("A possible solution is {0}, {1}, {2}, {3}, and {4}", keysArray[i],
                                        valuesArray[j], valuesArray[k], valuesArray[l], valuesArray[m]);
                                    int sumOfPrimePairs = keysArray[i] + valuesArray[j] + valuesArray[k] +
                                                          valuesArray[l] + valuesArray[m];
                                    if (sumOfPrimePairs < lowestSumOfPrimePairs)
                                    {
                                        lowestSumOfPrimePairs = sumOfPrimePairs;
                                        values = new List<int>();
                                        values.Add(keysArray[i]);
                                        values.Add(valuesArray[j]);
                                        values.Add(valuesArray[k]);
                                        values.Add(valuesArray[l]);
                                        values.Add(valuesArray[m]);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Debug.WriteLine("The winning numbers are {0}, {1}, {2}, {3}, and {4}.", values[0], values[1], values[2], values[3], values[4]);
            return lowestSumOfPrimePairs;
        }

        public static int FindPrimePairSetsNoDictionary(int numberOfPrimes)
        {
            int lowestSumOfPrimePairs = Int32.MaxValue;
            bool[] primeSieve = SharedCode.Math.GeneratePrimeSieve(limit: 10000000);
            var primeNumbers = SharedCode.Math.GeneratePrimeList(limit: 10000).ToArray();
            List<int> values = new List<int>();

            for (int i = 0; i < primeNumbers.Length - 4; i++)
            {
                for (int j = i + 1; j < primeNumbers.Length - 3; j++)
                {
                    if (!CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[i], prime2: primeNumbers[j]))
                    {
                        continue;
                    }
                    for (int k = j + 1; k < primeNumbers.Length - 2; k++)
                    {
                        if (!CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[i],
                                prime2: primeNumbers[k]) ||
                            !CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[j], prime2: primeNumbers[k]))
                        {
                            continue;
                        }
                        for (int l = k + 1; l < primeNumbers.Length - 1; l++)
                        {
                            if (!CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[i],
                                    prime2: primeNumbers[l]) ||
                                !CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[j],
                                    prime2: primeNumbers[l]) ||
                                !CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[k],
                                    prime2: primeNumbers[l]))
                            {
                                continue;
                            }
                            for (int m = l + 1; m < primeNumbers.Length; m++)
                            {
                                if (!CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[i],
                                        prime2: primeNumbers[m]) ||
                                    !CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[j],
                                        prime2: primeNumbers[m]) ||
                                    !CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[k],
                                        prime2: primeNumbers[m]) ||
                                    !CheckIfPrimePair(primeSieve: primeSieve, prime1: primeNumbers[l],
                                        prime2: primeNumbers[m]))
                                {
                                    continue;
                                }

                                {
                                    Debug.WriteLine("A possible solution is {0}, {1}, {2}, {3}, and {4}",
                                        primeNumbers[i],
                                        primeNumbers[j], primeNumbers[k], primeNumbers[l], primeNumbers[m]);
                                    int sumOfPrimePairs = primeNumbers[i] + primeNumbers[j] + primeNumbers[k] +
                                                          primeNumbers[l] + primeNumbers[m];
                                    if (sumOfPrimePairs < lowestSumOfPrimePairs)
                                    {
                                        lowestSumOfPrimePairs = sumOfPrimePairs;
                                        values = new List<int>();
                                        values.Add(item: primeNumbers[i]);
                                        values.Add(item: primeNumbers[j]);
                                        values.Add(item: primeNumbers[k]);
                                        values.Add(item: primeNumbers[l]);
                                        values.Add(item: primeNumbers[m]);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Debug.WriteLine("The winning numbers are {0}, {1}, {2}, {3}, and {4}.", values[0], values[1], values[2], values[3], values[4]);
            return lowestSumOfPrimePairs;
        }

        private static Dictionary<int, List<int>> TrimTheImpossibleOnes(Dictionary<int, List<int>> dictionary,
            bool[] primeSieve, int numPrimes)
        {
            Dictionary<int, List<int>> trimmedDictionary = new Dictionary<int, List<int>>();
            foreach (var pair in dictionary)
            {
                if (pair.Value.Count >= numPrimes - 1)
                {
                    trimmedDictionary.Add(key: pair.Key, value: pair.Value);
                }
            }

            return trimmedDictionary;
        }

        private static Dictionary<int, List<int>> TrimSome(Dictionary<int, List<int>> dictionary, bool[] primeSieve)
        {
            Dictionary<int, List<int>> trimmedDictionary = new Dictionary<int, List<int>>();
            int[] keysArray = dictionary.Keys.ToArray();
            for (int i = 0; i < keysArray.Length; i++)
            {
                int[] valuesArray = dictionary[keysArray[i]].ToArray();
                for (int j = 0; j < valuesArray.Length - 1; j++)
                {
                    for (int k = j + 1; k < valuesArray.Length; k++)
                    {
                        if (CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[j], prime2: valuesArray[k]))
                        {
                            AddToDictionary(dictionary: trimmedDictionary, originalPrimeNumber: keysArray[i],
                                addedPrimeNumber: valuesArray[j]);
                            AddToDictionary(dictionary: trimmedDictionary, originalPrimeNumber: keysArray[i],
                                addedPrimeNumber: valuesArray[k]);
                        }
                    }
                }
            }

            return trimmedDictionary;
        }

        private static Dictionary<int, List<int>> TrimSomeMore(Dictionary<int, List<int>> dictionary, bool[] primeSieve)
        {
            Dictionary<int, List<int>> trimmedDictionary = new Dictionary<int, List<int>>();
            int[] keysArray = dictionary.Keys.ToArray();
            for (int i = 0; i < keysArray.Length; i++)
            {
                int[] valuesArray = dictionary[keysArray[i]].ToArray();
                for (int j = 0; j < valuesArray.Length - 2; j++)
                {
                    for (int k = j + 1; k < valuesArray.Length - 1; k++)
                    {
                        for (int l = k + 1; l < valuesArray.Length; l++)
                        {
                            if (CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[j],
                                    prime2: valuesArray[k]) &&
                                CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[j],
                                    prime2: valuesArray[l]) &&
                                CheckIfPrimePair(primeSieve: primeSieve, prime1: valuesArray[k],
                                    prime2: valuesArray[l]))
                            {
                                AddToDictionary(dictionary: trimmedDictionary,
                                    originalPrimeNumber: keysArray[i], addedPrimeNumber: valuesArray[j]);
                                AddToDictionary(dictionary: trimmedDictionary,
                                    originalPrimeNumber: keysArray[i], addedPrimeNumber: valuesArray[k]);
                                AddToDictionary(dictionary: trimmedDictionary,
                                    originalPrimeNumber: keysArray[i], addedPrimeNumber: valuesArray[l]);
                            }
                        }
                    }
                }
            }

            return trimmedDictionary;
        }

        private static bool CheckIfPrimePair(bool[] primeSieve, int prime1, int prime2)
        {
            bool returnValue = true;
            int newNum = (prime1 * (int)Math.Pow(x: 10, y: SharedCode.Math.GetNumberOfDigits(value: prime2))) + prime2;
            int newNum2 = (prime2 * (int)Math.Pow(x: 10, y: SharedCode.Math.GetNumberOfDigits(value: prime1))) + prime1;
            if (newNum < primeSieve.Length)
            {
                returnValue = !primeSieve[newNum];
            }
            else
            {
                returnValue = SharedCode.Math.IsItPrime(number: newNum);
            }

            if (returnValue && newNum2 < primeSieve.Length)
            {
                returnValue = !primeSieve[newNum2];
            }
            else if (returnValue)
            {
                returnValue = SharedCode.Math.IsItPrime(number: newNum2);
            }

            return returnValue;
        }

        private static void AddToDictionary(Dictionary<int, List<int>> dictionary, int originalPrimeNumber,
            int addedPrimeNumber)
        {
            if (!dictionary.ContainsKey(key: originalPrimeNumber))
            {
                dictionary.Add(key: originalPrimeNumber, value: new List<int>());
            }

            if (!dictionary[originalPrimeNumber].Contains(item: addedPrimeNumber))
            {
                bool abort = false;
                if (dictionary.ContainsKey(addedPrimeNumber))
                {
                    if (dictionary[addedPrimeNumber].Contains(originalPrimeNumber))
                    {
                        abort = true;
                    }
                }

                if (!abort)
                {
                    dictionary[originalPrimeNumber].Add(item: addedPrimeNumber);
                }
            }
        }
    }
}
