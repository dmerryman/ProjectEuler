using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SummationOfPrimes
    {
        public static long FindSummationOfPrimesSlow(int limit)
        {
            long sumOfPrimes = 0;
            for (int i = 1; i < limit; i++)
            {
                if (SharedCode.Math.IsItPrime(number: i))
                {
                    sumOfPrimes += i;
                }
            }

            return sumOfPrimes;
        }
    }
}
