using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems1_10
{
    public static class LargestPrimeFactor
    {
        public static long FindLargestPrimeFactor(long number)
        {
            long currNum = (long)Math.Ceiling(Math.Sqrt(number));
            bool[] sieve = generateSieve(currNum + 1);
            for (int i = sieve.Length - 1; i > 1; i--)
            {
                if (number % i == 0 && !sieve[i])
                {
                    return i;
                }
            }

            /**
             * This is probably slower.
             */

            //while (currNum > 1)
            //{
            //    currNum--;
            //    if (number % currNum == 0 && IsItPrime(currNum))
            //    {
            //        return currNum;
            //    }
            //}
            throw new NotImplementedException("Largest Prime Factor not found");
        }


        private static bool IsItPrime(long possiblePrime)
        {
            Console.WriteLine("Checking if {0} is prime", possiblePrime);
            long currNum = possiblePrime - 1;
            while (currNum > 1)
            {
                if (possiblePrime % currNum == 0)
                {
                    return false;
                }
                currNum--;
            }
            return true;
        }

        private static bool[] generateSieve(long highestNumber)
        {
            bool[] sieve = new bool[highestNumber];
            for (int i = 2; i < highestNumber; i++)
            {
                if (!sieve[i])
                {
                    int multiple = 2;
                    int currNum = i * multiple;
                    while (currNum < highestNumber)
                    {
                        sieve[currNum] = true;
                        multiple++;
                        currNum = i * multiple;
                    }
                }
            }
            return sieve;
        }
    }
}
