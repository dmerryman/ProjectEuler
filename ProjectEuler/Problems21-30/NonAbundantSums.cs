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
            
            // Loop from 12 to 28123
            // For each number, determine if it can be written as the sum of two abundant numbers.
            // initialize sumOfNonAbundantNumbers to track the sum of nonabundant numbers.
            // If the number cannot be written as the sum of two abundant numbers, add the number to SumOfNonAbundantNumbers
            // return sumOfNonAbundantNumbers.
            throw new Exception();
        }

        public static bool CanBeWrittenAsSumOfTwoAbundantNumbers(int number)
        {
            // Loop from  i = 12 to number - 12.
            // Loop from j = i to number - 12
            // Check to see if i + j == number
                // if i + j == number, and both are abundant, return true.
            // return false.
            throw new NotImplementedException();
        }

        public static bool IsNumberAbundant(int number)
        {
            // Get the proper divisors for number, and add them up.
            // If the sum of the proper divisors is greater than number, return true. Otherwise, return false.
            throw new NotImplementedException();
        }
    }
}
