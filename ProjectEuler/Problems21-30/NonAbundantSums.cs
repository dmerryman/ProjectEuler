using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class NonAbundantSums
    {
        public static int FindNonAbundantSums()
        {
            // An abundant number is a number if the sum of its proper divisors is greater than the number.
            // All numbers greater than 28123 can be written as the sum of two abundant numbers.
            
            // Loop from 23 to 28123
            // For each number, determine if it can be written as the sum of two abundant numbers.
            // initialize sumOfNonAbundantNumbers to track the sum of nonabundant numbers.
            // If the number cannot be written as the sum of two abundant numbers, add the number to SumOfNonAbundantNumbers
            // return sumOfNonAbundantNumbers.
            int sumOfNonAbundantNumbers = 0;
            for (int i = 23; i <= 28123; i++)
            {
                if (!CanBeWrittenAsSumOfTwoAbundantNumbersSlowest(number: i))
                {
                    sumOfNonAbundantNumbers += i;
                }
            }

            return sumOfNonAbundantNumbers;
        }

        public static bool CanBeWrittenAsSumOfTwoAbundantNumbersSlowest(int number)
        {
            // Loop from  i = 12 to number - 12.
            // Loop from j = i to number - 12
            // Check to see if i + j == number
                // if i + j == number, and both are abundant, return true.
            // return false.
            for (int i = 12; i <= number - 12; i++)
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

        private static int[] GenerateAbundantNumberSieve()
        {
            // Loop from i = 1 to 28123.
            // If i is an abundant number, set it to true.
            // return the sieve.
            throw new NotImplementedException();
        }

        private static bool CanBeWrittenAsSumOfTwoAbundantNumbersSieve(int number, int[] sieve)
        {
            // Loop from i = 12 to number - 12; 
            // return true if i and number - i are in the sieve.
            // return false.
            throw new NotImplementedException();
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
