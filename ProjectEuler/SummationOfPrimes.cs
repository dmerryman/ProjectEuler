using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SummationOfPrimes
    {
        public static long FindSummationOfPrimesFaster(int limit)
        {
            long sumOfPrimes = 0;
            bool[] sieve = SharedCode.Math.GeneratePrimeSieve(limit: limit);
            for (int i = 2; i < limit; i++)
            {
                if (!sieve[i])
                {
                    sumOfPrimes += i;
                }
            }
            return sumOfPrimes;
        }
    }
}
