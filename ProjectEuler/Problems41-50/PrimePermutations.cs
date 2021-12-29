using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
