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
        public static int FindPrimePermutations()
        {
            // Get a sieve for 4 digit prime numbers.
            // Loop through every prime in sieve.
                // Get all permutations of the prime.
                    // check to see if any 3 of the permutations meet the requirement (all prime, same interval between them.
            bool[] primeSieve = ProjectEuler.SharedCode.Math.GeneratePrimeSieve(limit: 10000);
            for (int testValue = 1001; testValue < primeSieve.Length; testValue += 2)
            {
                if (!primeSieve[testValue])
                {
                    // This is prime.
                    String testValueString = testValue.ToString();
                    int[] primePermutations = GetPrimePermutations(primeNumber: testValue, primeSieve: primeSieve).OrderBy(s =>s).ToArray();
                    if (primePermutations.Length > 2)
                    {
                        HashSet<int> differences = new HashSet<int>();
                        List<Pair> pairs = new List<Pair>();
                        for (int i = 0; i < primePermutations.Length - 1; i++)
                        {
                            for (int j = i + 1; j < primePermutations.Length; j++)
                            {
                                int difference = primePermutations[j] - primePermutations[i];
                                if (!differences.Add(difference))
                                {
                                    // Possible Match.
                                    Pair newPair = new Pair(firstNum: primePermutations[i], primePermutations[j]);
                                    pairs.Add(item: newPair);
                                }
                            }
                        }

                        if (pairs.Count > 1)
                        {
                            foreach (var pair in pairs)
                            {
                                for (int i = 0; i < primePermutations.Length - 1; i++)
                                {
                                    for (int j = 0; j < primePermutations.Length; j++)
                                    {
                                        Pair newPair = new Pair(firstNum: primePermutations[i],
                                            secondNum: primePermutations[j]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new NotImplementedException();
        }

        //private bool CheckIntervals(int[,] differences)
        //{
        //    HashSet<int> differences = new HashSet<int>();
        //    for (int col = 0; col < differences.GetLength(0); col++)
        //    {
        //        for (int row = 0; row < differences.GetLength(1); row++)
        //        {

        //        }
        //    }
        //}

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

    public class Pair
    {
        private int FirstNum { get; set; }
        private int SecondNum { get; set; }

        public Pair(int firstNum, int secondNum)
        {
            this.FirstNum = firstNum;
            this.SecondNum = secondNum;
        }

        public bool InSequence(Pair otherPair)
        {
            return otherPair.FirstNum == this.SecondNum || this.FirstNum == otherPair.SecondNum;
        }

        public bool InSequenceEqualIntervals(Pair otherPair)
        {
            return otherPair.FirstNum - this.FirstNum == otherPair.SecondNum - otherPair.FirstNum;
        }


    }
}
