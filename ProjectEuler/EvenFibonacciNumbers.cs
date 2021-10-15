using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class EvenFibonacciNumbers
    {
        public static int FindEvenFibonacciNumbers(int limit)
        {
            int lastNum = 1;
            int secondToLastNum = 2;
            int fibonacciNumber = lastNum + secondToLastNum;
            int sumOfEvenValueTerms = 2;
            while (fibonacciNumber < limit)
            {
                if (fibonacciNumber % 2 == 0)
                {
                    sumOfEvenValueTerms += fibonacciNumber;
                }
                fibonacciNumber = lastNum + secondToLastNum;
                lastNum = secondToLastNum;
                secondToLastNum = fibonacciNumber;
            }
            return sumOfEvenValueTerms;
        }
    }
}
