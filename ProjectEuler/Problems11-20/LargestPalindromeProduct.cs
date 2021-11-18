using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems11_20
{
    public static class LargestPalindromeProduct
    {
        public static int FindLargestPalindromeProduct(int numDigits)
        {
            double upperlimit = (Math.Pow(x: 10, y: numDigits));
            int largestPalindrome = int.MinValue;
            for (int i = 0; i < upperlimit; i++)
            {
                for (int j = 0; j < upperlimit; j++)
                {
                    int testValue = i * j;
                    if (IsPalindrome(value: testValue))
                    {
                        if (testValue > largestPalindrome)
                        {
                            largestPalindrome = testValue;
                        }
                    }
                }
            }
            return largestPalindrome;
        }

        private static bool IsPalindrome(int value)
        {
            char[] charArray = value.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length / 2; i++)
            {
                if (charArray[i] != charArray[charArray.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
