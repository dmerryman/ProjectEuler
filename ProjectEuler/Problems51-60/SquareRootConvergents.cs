using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler.Problems51_60
{
    public static class SquareRootConvergents
    {
        public static int FindSquareRootConvergents(int limit)
        {
            int numExpansionsWithMoreDigitsInNumerator = 0;
            BigInteger numerator = 3;
            BigInteger denominator = 2;
            for (int i = 0; i < limit - 1; i++)
            {
                BigInteger oldNumerator = numerator;
                numerator = oldNumerator + (2 * denominator);
                denominator = oldNumerator + denominator;
                if (SharedCode.Math.GetNumberOfDigits(numerator) > SharedCode.Math.GetNumberOfDigits(denominator))
                {
                    numExpansionsWithMoreDigitsInNumerator++;
                }
            }
            return numExpansionsWithMoreDigitsInNumerator;
        }

    }
}
