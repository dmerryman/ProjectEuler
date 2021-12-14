using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class TrunctablePrimes
    {
        public static int FindTrunctablePrimes()
        {
            // int numTrunctablePrimes = 0 to track the number of trunctable primes.
            // int sumTrunctablePrimes = 0 to track the sum of trunctable primes.
            // Loop until numTrunctablePrimes == 11
                // Check if a number is prime.
                    // if it is, get a list of each possible variation of the number, and check to see if they're prime.
                    // if they all are, increment numTrunctablePrimes by one, and add the number to 
                    // sumTrunctablePrimes.
            // return sumTrunctablePrimes.
            int numTrunctablePrimns = 0;
            int sumTrunctablePrimes = 0;
            int currNum = 11;
            while (numTrunctablePrimns < 11)
            {
                if (SharedCode.Math.IsItPrime(number: currNum))
                {

                }

                currNum++;
            }
            throw new NotImplementedException();
        }

        private static int IsItATrunctablePrime(int value)
        {
            throw new NotImplementedException();
        }

        private static List<int> GetNumberVariations(int value)
        {
            throw new NotImplementedException();
        }
    }
}
