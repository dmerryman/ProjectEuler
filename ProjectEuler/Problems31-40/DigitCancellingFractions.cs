using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class DigitCancellingFractions
    {
        public static int FindDigitCancellingFractions()
        {
            // int currNumeratorProduct = 1
            // int currDenominatorProduct = 1
            // Loop for int denominator = 11 to 99
                // Loop for numerator = 10 to numerator 
                    // Get the digits in the numerator and denominator in a List<int>
                    // Check each combination of numerator and denominator to see if cancelling a digit
                    // still has the same value as a result, and that this function isn't trivial.
                    // if so, multiply currNumeratorProduct and currDenominatorProduct appropiately.

            int currNumeratorProduct = 1;
            int currDenominatorProduct = 1;
            for (int denominator = 11; denominator <= 99; denominator++)
            {
                for (int numerator = 10; numerator < denominator; numerator++)
                {
                    if (CanBeIncorrectlyReduced(numerator: numerator, denominator: denominator))
                    {
                        currNumeratorProduct *= numerator;
                        currDenominatorProduct *= denominator;
                    }
                }
            }

            return currDenominatorProduct;
        }

        public static bool CanBeIncorrectlyReduced(int numerator, int denominator)
        {
            if (numerator % 10 == 0 || denominator % 10 == 0)
            {
                return false;
            }
            int[] numeratorDigits = SharedCode.Math.GetDigits(value: numerator).ToArray();
            int[] denominatorDigits = SharedCode.Math.GetDigits(value: denominator).ToArray();
            for (int i = 0; i < numeratorDigits.Length; i++)
            {
                for (int j = 0; j < denominatorDigits.Length; j++)
                {
                    if (numeratorDigits[i] == denominatorDigits[j])
                    {
                        //Debug.WriteLine("{0} could be reduced in {1} / {2}", numeratorDigits[i], numerator, denominator);
                        int newNumerator = i == 0? numeratorDigits[1]: numeratorDigits[0];
                        int newDenominator = j == 0? denominatorDigits[1] : denominatorDigits[0];
                        if (newDenominator != 0)
                        {
                            if (Decimal.Divide(d1: numerator, d2: denominator) ==
                                Decimal.Divide(d1: newNumerator, d2: newDenominator))
                            {
                                Debug.WriteLine("Through sheer dumb like, {0} / {1} is actually equivalent to {2} / {3}",
                                    numerator, denominator, newNumerator, newDenominator);
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
