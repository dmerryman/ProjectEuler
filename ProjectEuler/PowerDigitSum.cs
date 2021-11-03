using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class PowerDigitSum
    {
        public static int FindPowerDigitSum(int exponent)
        {
            int[] digits = new int[exponent / 2];
            digits[digits.Length - 1] = 2;
            for (int i = 1; i < exponent; i++)
            {
                for (int j = digits.Length - 1; j >= 0; j--)
                {
                    digits[j] *= 2;
                }
                Carry(digits: digits);
            }
            int sumOfDigits = CountEmUp(digits: digits);
            return sumOfDigits;
        }

        public static int FindPowerDigitSumCheatingWithBigInt(int exponent)
        {
            BigInteger bigInt = new BigInteger(2);
            int sumOfDigits = 0;
            bigInt = BigInteger.Pow(value: bigInt, exponent: exponent);

            char[] digits = bigInt.ToString().ToCharArray();
            foreach (char c in digits)
            {
                sumOfDigits += (int)Char.GetNumericValue(c);
            }

            return sumOfDigits;
        }

        private static void Carry(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] >= 10)
                {
                    int numToCarry = digits[i] / 10;
                    int leftover = digits[i] % 10;
                    digits[i - 1] += numToCarry;
                    digits[i] = leftover;
                }
            }
        }

        private static int CountEmUp(int[] digits)
        {
            int sumOfDigits = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sumOfDigits += digits[i];
            }

            return sumOfDigits;
        }
    }
}
