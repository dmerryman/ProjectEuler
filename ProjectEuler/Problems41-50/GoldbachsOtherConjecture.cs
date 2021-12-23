using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class GoldbachsOtherConjecture
    {
        public static int FindGoldbachsOtherConjecture()
        {
            // Loop while true
                // int currNum = 2 as a starting number
                    // If it's a composite number, check if it cant be written as the sum of a prime and twice a square
                        // if it can be, return that number.
            int currNum = 2;
            while (true)
            {

                currNum++;
            }

            if (!SharedCode.Math.IsItPrime(number: currNum))
            {

            }
        }

        public static bool CanBeWrittenAsSum(int testValue)
        {
            // for int index = 2 to testValue
                // check to see if index is prime
                    // if it is, check to see if a square can be added to it.
            throw new NotImplementedException();
        }

        public static bool CanBeCompletedWithASquare(int primeValue, int testValue)
        {
            // for int i = 1 to testValue
                // for int j = 1 until i * j > testValue
                    // check if primeValue + i * j == testValue
                        // if it is, return true.
                // increment j
            // increment i
            // return false
            for (int i = 1; i < testValue; i++)
            {
                for (int j = 1; i * j < testValue; j++)
                {
                    if (primeValue + (i * j) == testValue)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
