using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            int sumOfAmicableNumbers = 0;
            for (int i = 220; i < ceiling; i++)
            {
                int amicableNumber = FindSumOfDivisors(number: i);
                if (FindSumOfDivisors(number: amicableNumber) == i && amicableNumber != i)
                {
                    sumOfAmicableNumbers += i;
                }
            }

            return sumOfAmicableNumbers;
        }

        public static int FindAmicableNumbersUsingHashset(int ceiling)
        {
            int sumOfAmicableNumbers = 0;
            HashSet<int> amicableNumbers = new HashSet<int>();
            for (int i = 220; i < ceiling; i++)
            {
                if (!amicableNumbers.Contains(i))
                {
                    int amicableNumber = FindSumOfDivisors(number: i);
                    int otherAmicableNumber = FindSumOfDivisors(number: amicableNumber);
                    if (otherAmicableNumber == i && amicableNumber != i)
                    {
                        amicableNumbers.Add(item: amicableNumber);
                        amicableNumbers.Add(item: otherAmicableNumber);
                        sumOfAmicableNumbers += amicableNumber + otherAmicableNumber;
                    }
                }
            }

            amicableNumbers = null;
            return sumOfAmicableNumbers;
        }

        private static int FindSumOfDivisors(int number)
        {
            // Get the list of divisors and then add them up.
            int sumOfDivisors = 0;
            List<int> divisors = SharedCode.Math.FindProperDivisorsOf(number: number);
            foreach (int i in divisors)
            {
                sumOfDivisors += i;
            }

            return sumOfDivisors;
        }
    }
}
