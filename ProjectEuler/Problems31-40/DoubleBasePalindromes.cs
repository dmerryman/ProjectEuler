using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo(assemblyName: "ProjectEulerTests.Problems31_40")]
namespace ProjectEuler.Problems31_40
{
    public static class DoubleBasePalindromes
    {
        public static int FindDoubleBasePalindromes(int limit)
        {
            // int sumOfDoubleBasePalindromes = 0 to track the sum of double base palindromes.
            // Loop for i from 1 to limit.
                // Check to see if i is a palindrom.
                    // if it is, convert to base 2 and check to see if that is a palindrome.
                        // if it is, then add i to sumOfDoubleBasePalindromes
            // return sumOfDoubleBasePalindromes
            int sumOfDoubleBasePalindromes = 0;
            for (int i = 0; i < limit; i++)
            {
                if (SharedCode.Math.IsItAPalindrome(value: i))
                {
                    String baseTwoValue = ConvertToBaseTwo(value: i);
                    if (SharedCode.Strings.IsItAPalindrome(s: baseTwoValue))
                    {
                        sumOfDoubleBasePalindromes += i;
                    }
                }
            }

            return sumOfDoubleBasePalindromes;
        }

        public static String ConvertToBaseTwo(int value)
        {
            return Convert.ToString(value: value, toBase: 2);
            
        }
    }
}
