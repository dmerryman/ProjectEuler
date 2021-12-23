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
            int currNum = 3;
            while (true)
            {
                if (!SharedCode.Math.IsItPrime(number: currNum))
                {
                    if (!CanBeWrittenAsSum(testValue: currNum))
                    {
                        break;
                    }
                }
                currNum += 2;
            }

            return currNum;
        }

        public static bool CanBeWrittenAsSum(int testValue)
        {
            // for int index = 2 to testValue
                // check to see if index is prime
                    // if it is, check to see if a square can be added to it.
            for (int index = 2; index < testValue; index++)
            {
                if (SharedCode.Math.IsItPrime(number: index))
                {
                    if (CanBeCompletedWithASquare(primeValue: index, testValue: testValue))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool CanBeCompletedWithASquare(int primeValue, int testValue)
        {
            for (int i = 1; 2 * i * i <= testValue; i++)
            {
                if (primeValue + (2 * i * i) == testValue)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
