using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.SharedCode;

namespace ProjectEuler.Problems21_30
{
    public static class _1000DigitFibonacciNumber
    {
        public static int Find1000DigitFibonacciNumber()
        {
            return Find1000DigitFibonacciNumberCheats();
        }

        public static int Find1000DigitFibonacciNumberCheats()
        {
            BigInteger num1 = 1;
            BigInteger num2 = 1;
            int index = 2;
            int numDigits = 1;
            while (numDigits < 1000)
            {
                BigInteger result = num1 + num2;
                num1 = num2;
                num2 = result;
                numDigits = result.ToString().Length;
                index++;
            }

            return index;
        }

        public static int Find1000DigitFibonacciNumberMine()
        {
            BigNumber num1 = new BigNumber("1");
            BigNumber num2 = new BigNumber("1");
            int index = 2;
            int numDigits = 1;
            while (numDigits < 1000)
            {
                BigNumber result = num1.Addition(otherNumber: num2);
                num1 = num2;
                num2 = result;
                numDigits = result.ToString().Length;
                index++;
            }

            return index;
        }
    }
}
