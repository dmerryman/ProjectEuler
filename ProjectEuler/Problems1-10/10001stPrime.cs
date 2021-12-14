using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems1_10
{
    public static class _10001stPrime
    {
        public static int FindNthPrime(int n)
        {
            int count = 1;
            int testValue = 1;
            while (count < n)
            {
                testValue += 2;
                if (IsItPrime(num: testValue))
                {
                    //Console.WriteLine("{0} is prime", testValue);
                    count++;
                }
            }
            return testValue;
        }

        private static bool IsItPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            else if (num < 4)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else if (num < 9)
            {
                return true;
            }
            else if (num % 3 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 5; i <= Math.Sqrt(num); i += 6)
                {
                    if (num % i == 0 || num % (i + 2) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
