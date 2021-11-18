using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems11_20
{
    public static class FactorialDigitSum
    {
        public static int FindFactorialDigitSum(int ceiling)
        {
            int numDigits = ceiling * (int)Math.Ceiling(Math.Log10(d: ceiling / 2));
            int[] data = new int[numDigits];
            data[data.Length - 1] = ceiling;
            for (int i = ceiling - 1; i > 0; i--)
            {
                for (int j = data.Length - 1; j >= 0; j--)
                {
                    data[j] *= i;
                }
                Carry(data: data);
            }

            int sumOfDigits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sumOfDigits += data[i];
            }

            return sumOfDigits;
        }

        private static void Carry(int[] data)
        {
            for (int i = data.Length - 1; i > 1; i--)
            {
                if (data[i] >= 10)
                {
                    int tempNum = data[i];
                    data[i] = data[i] % 10;
                    data[i - 1] += tempNum / 10;
                }
            }
        }

        public static int FindFactorialDigitSumCheatString(int ceiling)
        {
            // Just use BigInt, but it kind of defeats the purpose.
            int sumOfDigits = 0;
            BigInteger bigInt = new BigInteger(ceiling);
            for (int i = ceiling - 1; i > 0; i--)
            {
                bigInt *= i;
            }

            char[] digits = bigInt.ToString().ToCharArray();
            foreach (char c in digits)
            {
                sumOfDigits += (int)Char.GetNumericValue(c);
            }

            return sumOfDigits;
        }

        public static int FindFactorialDigitSumCheatModulus(int ceiling)
        {
            // Just use BigInt, but it kind of defeats the purpose.
            int sumOfDigits = 0;
            BigInteger bigInt = new BigInteger(ceiling);
            for (int i = ceiling - 1; i > 0; i--)
            {
                bigInt *= i;
            }

            while (bigInt > 0)
            {
                sumOfDigits += (int)(bigInt % 10);
                bigInt /= 10;
            }

            return sumOfDigits;
        }
    }
}
