using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class DigitFactorials
    {
        public static long FindDigitFactorials()
        {
            // int currSum = 0;
            // Find the upper limit.
            // Loop from int i = 3 to upper limit.
            // Get the digits of i.
            // Calculate the sum of the factorials of the digits.
            // If the sum of the factorials of the digits is equal to the original number, add
            // that to currSum
            // return currSum.
            int totalSumOfFactorials = 0;
            for (int i = 3; i <= 362880; i++)
            {
                List<int> digits = ProjectEuler.SharedCode.Math.GetDigits(value: i);
                int sumOfFactorials = 0;
                foreach (int d in digits)
                {
                    sumOfFactorials += SharedCode.Math.CalculateFactorial(value: d);
                }

                if (sumOfFactorials == i)
                {
                    Debug.WriteLine("This works for {0}", i);
                    totalSumOfFactorials += i;
                }
            }

            return totalSumOfFactorials;
        }

        
    }
}
