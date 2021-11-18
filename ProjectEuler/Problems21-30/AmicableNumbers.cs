using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class AmicableNumbers
    {
        public static int FindAmicableNumbers(int ceiling)
        {
            // loop from 3 to ceiling.
            // for each number, find the sum of the divisors as N,
            // then find the sum of the divisors for N. If the sum of the divisors for N
            // is equal to the original number, those 2 numbers are an amicable pair.
            throw new NotImplementedException();
        }

        private static int FindSumOfDivisors(int number)
        {
            // Get the list of divisors and then add them up.
            throw new NotImplementedException();
        }
    }
}
