using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

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
                        //Debug.WriteLine("{0} is a circular prime", testValue);
                        numOfCircularPrimes++;
                    }
                }
            }
            return numOfCircularPrimes;
        }

        public static bool AreAllPermutationsPrime(int value)
        {
            if (value == 19)
            {
                int pause = 1;
            }
            bool allPrime = true;
            List<string> permutations = SharedCode.Strings.GetPermutations(value: value.ToString());
            foreach (string s in permutations)
            {
                int testValue = Int32.Parse(s: s);
                if (!SharedCode.Math.IsItPrime(number: testValue))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
