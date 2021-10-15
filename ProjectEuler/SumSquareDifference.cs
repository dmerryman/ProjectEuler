using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SumSquareDifference
    {
        public static int FindSumSquareDifferenceSlow(int limit)
        {
            int sumOfSquares = 0;
            int squareOfSum = 0;
            for (int i = 1; i <= limit; i++)
            {
                sumOfSquares += (int)Math.Pow(x: i, y: 2);
                squareOfSum += i;
            }
            squareOfSum = (int)Math.Pow(x: squareOfSum, y: 2);
            return squareOfSum - sumOfSquares;
        }

        public static int FindSumSquareDifferenceFaster(int limit)
        {
            int sumOfSquares = limit * (limit + 1) * ((2 * limit) + 1) / 6;
            int squareOfSums = (int)(Math.Pow(x: limit, y: 2) * (int)Math.Pow(x: limit + 1, y: 2) / 4);
            return (int)squareOfSums - sumOfSquares;
        }
    }
}
