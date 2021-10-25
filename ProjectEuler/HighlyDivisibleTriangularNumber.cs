using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class HighlyDivisibleTriangularNumber
    {
        public static int FindHighlyDivisibleTriangularNumber(int numDivisors)
        {
            int currNum = 1;
            int numToAdd = 2;
            int currNumDivisors = 1;
            while (currNumDivisors <= numDivisors)
            {
                currNum += numToAdd;
                numToAdd++;
                currNumDivisors = FindNumberOfDivisors(number: currNum);
                if (currNumDivisors == numDivisors)
                {
                    break;
                }
            }
            return currNum;
        }

        // A little slow.
        private static int FindNumberOfDivisors(int number)
        {
            int numDivisors = 1;
            for (int i = 2; i <= Math.Sqrt(d: number); i++)
            {
                if (number % i == 0)
                {
                    numDivisors += 2;
                }
            }
            numDivisors++;
            return numDivisors;
        }
    }
}
