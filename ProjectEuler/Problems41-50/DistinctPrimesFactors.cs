using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class DistinctPrimesFactors
    {
        public static int FindDistinctPrimesFactors(int numConsecutive)
        {
            // int currNumConsecutive = 0 to track number of consecutive numbers
            // int currFirstNum = Int32.minvalue to track the first number in the set of consecutive numbers.
            // int currNum = 1 to track the current test number.
                // Loop while currNumConsecutive < numConsecutive
                    // Check to see if this number has numConsecutive distinct Prime factors
                        // if so, incrememnt currNumConsecutive by one, and set currFirstNum to currNum if currNumConsecutive = 0.
                        // if not, set currNumConsecutive to 0.
                    // increment currNum.
            int currNumConsecutive = 0;
            int currFirstNum = Int32.MinValue;
            int currNum = 1;
            while (currNumConsecutive < numConsecutive)
            {

            }
            throw new NotImplementedException();
        }

        public static int GetNumberOfDistinctPrimeFactors(int number)
        {
            Dictionary<int, int> distinctPrimeFactorsDictionary = new Dictionary<int, int>();
            int loopThrough = number;
            for (int i = 2; i <= loopThrough / 2; i++)
            {
                if (number % i == 0)
                {
                    distinctPrimeFactorsDictionary.Add(key: i, value: 0);
                    while (number % i == 0)
                    {
                        number /= i;
                        distinctPrimeFactorsDictionary[i]++;
                    }
                }
            }

            return distinctPrimeFactorsDictionary.Keys.Count;
        }
    }
}
