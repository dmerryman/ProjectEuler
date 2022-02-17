using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems61_70
{
    public static class PowerfulDigitCounts
    {
        public static int FindPowerfulDigitCounts()
        {
            // int numPowerfulDigitNumbers = 0 to track the number of powerful digit numbers. end when x^y has more digits than y for y = 1?
            // for int currNum = 1 to (determine ceiling)
                // determine number of powerful digit numbers resulting from this currNum
                // Add number of powerful digit numbers to numPowerfulDigitNumbers.
            // return numPowerfulDigitNumbers
            int numPowerfulDigitNumbers = 0;
            int currentValue = 0;
            int currentNumberOfPowerfulDigitNumbers = 1;
            while (currentNumberOfPowerfulDigitNumbers > 0)
            {
                currentValue++;
                currentNumberOfPowerfulDigitNumbers = GetNumberOfPowerfulDigits(number: currentValue);
                numPowerfulDigitNumbers += currentNumberOfPowerfulDigitNumbers;
            }

            int pause = 1;
            return numPowerfulDigitNumbers;
        }

        public static int GetNumberOfPowerfulDigits(int number)
        {
            // int currNumberOfDigits to hold the number of digits in the current number.
            // int currExponent = 1 to track the current exponenet.
            // int currentValue = number to track the current value.
            // int currNumPowerfulDigits = 0 to track the number of powerful digit numbers.
            // While currNumberOfDigits > currExponent
                // Incrememnt currNumPowerfulDigits by 1. if currNumberOfDigits == currExponent
                // Increment currExponent by 1.
                // Calculate currentValue = number ^ currExponent
                // Calculate currNumberOfDigits = number of digits in currentValue.
            double currentValue = number;
            int currNumPowerfulDigits = 0;
            int currNumberOfDigits = SharedCode.Math.GetNumberOfDigits(value: currentValue);
            int currExponent = 1;
            while (currNumberOfDigits >= currExponent)
            {
                if (currNumberOfDigits == currExponent)
                {
                    currNumPowerfulDigits++;
                    Debug.WriteLine("{0} = {1}^{2}", currentValue, number, currExponent);
                }
                currExponent++;
                currentValue = Math.Pow(x: number, y: currExponent);
                currNumberOfDigits = SharedCode.Math.GetNumberOfDigits(value: currentValue);
            }

            Debug.WriteLine("");
            return currNumPowerfulDigits;
        }
    }
}
