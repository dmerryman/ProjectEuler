using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class NonAbundantSums
    {
        public static int FindNonAbundantSumsSlowest()
        {
            // An abundant number is a number if the sum of its proper divisors is greater than the number.
            // All numbers greater than 28123 can be written as the sum of two abundant numbers.
            
            // Loop from 23 to 28123
            // For each number, determine if it can be written as the sum of two abundant numbers.
            // initialize sumOfNonAbundantNumbers to track the sum of nonabundant numbers.
            // If the number cannot be written as the sum of two abundant numbers, add the number to SumOfNonAbundantNumbers
            // return sumOfNonAbundantNumbers.
            int sumOfNonAbundantNumbers = 0;
            for (int i = 12; i <= 28123; i++)
            {
                if (!CanBeWrittenAsSumOfTwoAbundantNumbersSlowest(number: i))
                {
                    sumOfNonAbundantNumbers += i;
                }
            }

            return sumOfNonAbundantNumbers;
        }

        public static int FindNonAbundantSumsSieve()
        {
            bool[] sieve = GenerateAbundantNumberSieve();
            int sumOfNonAbundantNumbers = 0;

            for (int i = 1; i <= 28123; i++)
            {
                if (!CanBeWrittenAsSumOfTwoAbundantNumbersSieve(number: i, sieve: sieve))
                {
                    sumOfNonAbundantNumbers += i;
                }
            }

            return sumOfNonAbundantNumbers;
        }

        private static bool CanBeWrittenAsSumOfTwoAbundantNumbersSlowest(int number)
        {
            // Loop from  i = 12 to number.
            // Loop from j = i to number
            // Check to see if i + j == number
                // if i + j == number, and both are abundant, return true.
            // return false.
            for (int i = 12; i <= number; i++)
            {
                for (int j = i; j <= number - 12; j++)
                {
                    if (i + j == number && IsNumberAbundant(number: i) && IsNumberAbundant(number: j))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool CanBeWrittenAsSumOfTwoAbundantNumbersSieve(int number, bool[] sieve)
        {
            // Loop from i = 12 to number - 12; 
            // return true if i and number - i are in the sieve.
            // return false.
            for (int i = 0; i < number; i++)
            {
                if (sieve[i] && sieve[number - i])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool[] GenerateAbundantNumberSieve()
        {
            // Loop from i = 1 to 28123.
            // If i is an abundant number, set it to true.
            // return the sieve.
            bool[] sieve = new bool[28124];
            for (int i = 12; i < sieve.Length; i++)
            {
                if (IsNumberAbundant(number: i))
                {
                    sieve[i] = true;
                }
            }

            return sieve;
        }

        private static bool IsNumberAbundant(int number)
        {
            // Get the proper divisors for number, and add them up.
            // If the sum of the proper divisors is greater than number, return true. Otherwise, return false.
            List<int> properDivisors = SharedCode.Math.FindProperDivisorsOf(number: number);
            int sumOfProperDivisors = 0;
            foreach (int i in properDivisors)
            {
                sumOfProperDivisors += i;
            }
            return (sumOfProperDivisors > number);
        }
    }
}
