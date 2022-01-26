using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PowerfulDigitSum
    {
        public static int FindPowerfulDigitSum(int limit)
        {
            //int maximumDigitalSum = -1 to track the maximumDigitalSum
            //for int a = 1 to limit - 1
                // for int b = 1 to limit - 1
                    // Calculate a^b
                    // Calculate the sum of digits in a^b
                    // Check to see if the sum of digits in a^b > maximumDigitalSum
                        // If it is, then set maximumDigitalSum to that result.
            // return maximumDigitalSum
            int maximumDigitalSum = -1;
            for (int a = 1; a < limit; a++)
            {
                for (int b = 1; b < limit; b++)
                {
                    var currResult = BigInteger.Pow(a, b);
                    var digitsList = SharedCode.Math.GetDigits(currResult);
                    int currSumOfDigits = 0;
                    foreach (var digit in digitsList)
                    {
                        currSumOfDigits += digit;
                    }

                    if (currSumOfDigits > maximumDigitalSum)
                    {
                        maximumDigitalSum = currSumOfDigits;
                        Debug.WriteLine("{0} is the new maximum digit sum for {1}^{2}", maximumDigitalSum, a, b);
                    }
                }
            }
            return maximumDigitalSum;
            throw new NotImplementedException();
        }
    }
}
