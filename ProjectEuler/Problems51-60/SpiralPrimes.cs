using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class SpiralPrimes
    {
        public static int FindSpiralPrimes(int percentageLimit)
        {
            // decimal percentage = 1.00 to track percentage of prime numbers in spiral.
            // int length = 1 to track the length of the side of the spiral.
            // int numPrimes = 0 to track number of prime numbers in spiral.
            // int numValues = 1 to track number of values.
            // Loop until percentage < percentageLimit / 100
            // Iterate through the spiral by adding length + 1 4 times and checking each number to see if its a prime.
            // For every prime, increment numPrimes by 1.
            // For every number, 
            // Calculate the percentage of primes.
            // Increment length by 2.
            // return length
            decimal percentageOfPrimeNumbers = 1.00M;
            decimal percentageLimitDecimal = (percentageLimit / 100.0M);
            int length = 1;
            int numPrimeValues = 0;
            int numValues = 1;
            int currNum = 1;
            while (percentageOfPrimeNumbers > percentageLimitDecimal)
            {
                for (int i = 0; i < 4; i++)
                {
                    currNum += (length + 1);
                    numValues++;
                    if (SharedCode.Math.IsItPrime(number: currNum))
                    {
                        numPrimeValues++;
                    }
                }
                length += 2;
                percentageOfPrimeNumbers = (decimal.Divide(numPrimeValues, numValues));
                //System.Diagnostics.Debug.WriteLine("{0}", percentageOfPrimeNumbers);
            }
            return length;
        }

        public static int FindSpiralPrimesWithSieve(int percentageLimit)
        {
            decimal percentageOfPrimeNumbers = 1.00M;
            decimal percentageLimitDecimal = (percentageLimit / 100.0M);
            int length = 1;
            int numPrimeValues = 0;
            int numValues = 1;
            int currNum = 1;
            bool[] primeSieve = SharedCode.Math.GeneratePrimeSieve(limit: 1000000000);
            while (percentageOfPrimeNumbers > percentageLimitDecimal)
            {
                for (int i = 0; i < 4; i++)
                {
                    currNum += (length + 1);
                    numValues++;
                    if (!primeSieve[currNum])
                    {
                        numPrimeValues++;
                    }
                }
                length += 2;
                percentageOfPrimeNumbers = (decimal.Divide(numPrimeValues, numValues));
                //System.Diagnostics.Debug.WriteLine("{0}", percentageOfPrimeNumbers);
            }
            return length;
        }

        public static int FindSpiralPrimesHybrid(int percentageLimit, int sieveLimit)
        {
            decimal percentageOfPrimeNumbers = 1.00M;
            decimal percentageLimitDecimal = (percentageLimit / 100.0M);
            int length = 1;
            int numPrimeValues = 0;
            int numValues = 1;
            int currNum = 1;
            bool[] primeSieve = SharedCode.Math.GeneratePrimeSieve(limit: sieveLimit);
            while (percentageOfPrimeNumbers > percentageLimitDecimal)
            {
                for (int i = 0; i < 4; i++)
                {
                    currNum += (length + 1);
                    numValues++;
                    if (currNum < sieveLimit)
                    {
                        if (!primeSieve[currNum])
                        {
                            numPrimeValues++;
                        }
                    }
                    else
                    {
                        if (SharedCode.Math.IsItPrime(number: currNum))
                        {
                            numPrimeValues++;
                        }
                    }
                }
                length += 2;
                percentageOfPrimeNumbers = (decimal.Divide(numPrimeValues, numValues));
                //System.Diagnostics.Debug.WriteLine("{0}", percentageOfPrimeNumbers);
            }
            return length;
        }
    }
}
