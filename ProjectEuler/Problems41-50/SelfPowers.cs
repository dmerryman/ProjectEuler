using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class SelfPowers
    {
        public static long FindSelfPowers(int limit)
        {
            BigInteger currentValue = 0;
            for (int i = 1; i <= limit; i++)
            {
                currentValue = BigInteger.Add(left: BigInteger.Pow(value: i, exponent: i), right: currentValue);
            }

            return (long)(currentValue % new BigInteger(10000000000));
        }
    }
}
