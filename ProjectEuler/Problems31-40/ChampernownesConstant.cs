using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class ChampernownesConstant
    {
        public static int FindChampernownesConstant()
        {
            // int digitCount = 0 to track number of digits.
            // int currNum = 0 to track the current number.
            // int multipleValue = 1 to track the multiple value to be returned.
                // Loop while digitCount <= 1000000
                    // increment currNum by one.
                    // Check to see if this value contains one of the decimal places we need to track.
                        // if it does, multiple multipleValue by that digit.
            // return multipleValue
            int digitCount = 0;
            int currNum = 0;
            int multipleValue = 1;
            int[] digitPositions = new int[] { 1, 10, 100, 1000, 10000, 100000, 1000000 };
            int currentOne = 0;
            while (digitCount <= 1000000)
            {
                currNum++;
                int numberOfDigitsForNextNumber = ProjectEuler.SharedCode.Math.GetNumberOfDigits(value: currNum);
                if (DidWePassOne(nextDigitPosition: digitPositions[currentOne], digitCount: digitCount,
                        numberOfDigitsToAdd: numberOfDigitsForNextNumber))
                {
                    int digitToMultiplyBy = GetDigitAtIndex(number: currNum, digit: digitPositions[currentOne] - digitCount);
                    //Debug.WriteLine("Multiplying by {0}", digitToMultiplyBy);
                    multipleValue *= digitToMultiplyBy;
                    currentOne++;
                }

                digitCount += numberOfDigitsForNextNumber;
            }

            return multipleValue;
        }

        public static bool DidWePassOne(int nextDigitPosition, int digitCount, int numberOfDigitsToAdd)
        {
            // if digitCount + numberOfDigitsToAdd > nextDigitPosition
                // return true
            // return false
            return digitCount + numberOfDigitsToAdd >= nextDigitPosition;
        }
        public static int GetDigitAtIndex(int number, int digit)
        {
            // Get the number of digits in number.
            // int i = 1 to track the currentDigit we're at..
            // divide by 10 and increment i each time until number of digits - 
            
            int numberOfDigitsInNumber = ProjectEuler.SharedCode.Math.GetNumberOfDigits(value: number);

            int i = 1;
            while (i < numberOfDigitsInNumber + 1 - digit)
            {
                number /= 10;
                i++;
            }

            int digitToReturn = number % 10;
            return digitToReturn;
        }
    }
}
