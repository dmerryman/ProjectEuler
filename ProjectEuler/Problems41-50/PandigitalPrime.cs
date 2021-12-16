using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class PandigitalPrime
    {
        public static int FindPandigitalPrime()
        {
            // int largestPandigitalPrime = int32.minvalue
            // Loop for int testValue = 2 to 987654321
                // Check to see if testValue is prime.
                    // if it is, check to see if it is also pandigital.
                        // if it is, check to see if it is larger than largestPandigitalPrime
                            // if it is, then set largestPandigitalPrime = testValue
            // return largestPandigitalPrime
            int largestPandigitalPrime = Int32.MinValue;
            for (int testValue = 3; testValue <= 987654321; testValue += 2)
            {
                if (SharedCode.Math.IsItPandigital(number: testValue))
                {
                    if (SharedCode.Math.IsItPrime(number: testValue))
                    {
                        largestPandigitalPrime =
                            testValue > largestPandigitalPrime ? testValue : largestPandigitalPrime;
                    }
                }
            }

            return largestPandigitalPrime;
        }

        public static int FindPandigitalPrimeWithSieve()
        {
            int largestPandigitalPrime = Int32.MinValue;
            bool[] primeSieve = SharedCode.Math.GeneratePrimeSieve(limit: 987654322);
            for (int testValue = 3; testValue <= 987654321; testValue += 2)
            {
                if (SharedCode.Math.IsItPandigital(number: testValue))
                {
                    if (primeSieve[testValue])
                    {
                        largestPandigitalPrime =
                            testValue > largestPandigitalPrime ? testValue : largestPandigitalPrime;
                    }
                }
            }

            return largestPandigitalPrime;
        }
    }
}
