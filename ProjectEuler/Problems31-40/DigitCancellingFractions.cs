﻿using System;
using System.Collections.Generic;
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
                for (int numerator = 10; numerator < numerator; numerator++)
                {

                }
            }
            throw new NotImplementedException();
        }
    }
}
