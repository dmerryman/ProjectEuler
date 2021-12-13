using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo(assemblyName: "ProjectEulerTests.Problems31_40")]
namespace ProjectEuler.Problems31_40
{
    public static class CircularPrimes
    {
        public static int FindCircularPrimes(int limit)
        {
            // int numOfCircularPrimes = 0 to track number of circular primes.
            // Loop for int testValue from 2 to limit - 1
            // For each testValue, get the permutations of each value.
                // Loop through each permutation
                // if all permutations are prime, then increment numOfCircularPrimes by one.
            // return numOfCircularPrimes
            int numOfCircularPrimes = 0;
            for (int testValue = 0; testValue < limit; testValue++)
            {
                if (SharedCode.Math.IsItPrime(number: testValue))
                {
                    if (AreAllPermutationsPrime(value: testValue))
                    {
                        Debug.WriteLine("{0} is a circular prime", testValue);
                        numOfCircularPrimes++;
                    }
                }
            }
            return numOfCircularPrimes;
        }

        public static bool AreAllPermutationsPrime(int value)
        {

            bool allPrime = true;
            List<int> cyclicalRotations = GetCyclicalPermutations(value: value);
            // only cyclical permutations.
            for (int i = 1; i < cyclicalRotations.Count; i++)
            {
                int testValue = cyclicalRotations[i];

                if (!SharedCode.Math.IsItPrime(number: testValue))
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> GetCyclicalPermutations(int value)
        {
            int numberOfDigits = SharedCode.Math.GetNumberOfDigits(value: value);
            List<int> cyclicalPermutations = new List<int>();
            cyclicalPermutations.Add(item: value);
            for (int i = 0; i < numberOfDigits - 1; i++)
            {
                int digitToCycle = value % 10;
                value /= 10;
                value += (int)Math.Pow(x: 10, y: numberOfDigits - 1) * digitToCycle;
                cyclicalPermutations.Add(item: value);
            }

            return cyclicalPermutations;
        }
    }
}
