using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class TriangularPentagonalAndHexagonal
    {
        public static long FindTriangularPentagonalAndHexagonal()
        {
            int n = 143;
            long currNum = 0;
            while (true)
            {
                n++;
                long testValue = n * (2 * n - 1);
                if (IsItPentagonal(value: testValue))
                {
                    return testValue;
                }
            }
        }

        public static bool IsItPentagonal(long value)
        {
            double testValue = (Math.Sqrt(d: 1 + 24 * value) + 1) / 6;
            if (SharedCode.Math.IsItAnInteger(testValue: testValue))
            {
                return true;
            }

            return false;
        }
    }
}
