using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class LongestCollatzSequence
    {
        public static int FindLongestCollatzSequenceSlow(int ceiling)
        {
            // From 1 to ceiling, go through the number of steps in each Collatz sequence, and get the number of steps involved.
            // For each number of steps, check if it exceeds the value of the previous maximum, and if so, set the maximum to be that value.
            // Return the maximum value
            int numberToCheck = 2;
            int numberOfSteps = GetNumberOfStepsInCollatzSequenceSlow(startingNumber: numberToCheck);
            int maximumNumberOfSteps = numberOfSteps;
            int valueWithMaximumNumberOfSteps = numberToCheck;
            while (numberToCheck <= ceiling)
            {
                numberToCheck++;
                numberOfSteps = GetNumberOfStepsInCollatzSequenceSlow(startingNumber: numberToCheck);
                if (numberOfSteps > maximumNumberOfSteps)
                {
                    maximumNumberOfSteps = numberOfSteps;
                    valueWithMaximumNumberOfSteps = numberToCheck;
                }
                //Debug.WriteLine("{0} had {1} steps. Maximum is {2} with {3}", numberToCheck, numberOfSteps, valueWithMaximumNumberOfSteps, maximumNumberOfSteps);
            }

            return valueWithMaximumNumberOfSteps;
        }

        public static int FindLongestCollatzSequenceFaster(int ceiling)
        {
            // From 1 to ceiling, go through the number of steps in each Collatz sequence, and get the number of steps involved.
            // For each number of steps, check if it exceeds the value of the previous maximum, and if so, set the maximum to be that value.
            // Return the maximum value
            int numberToCheck = ceiling / 2;
            int numberOfSteps = GetNumberOfStepsInCollatzSequenceSlow(startingNumber: numberToCheck);
            int maximumNumberOfSteps = numberOfSteps;
            int valueWithMaximumNumberOfSteps = numberToCheck;
            while (numberToCheck <= ceiling)
            {
                numberToCheck++;
                numberOfSteps = GetNumberOfStepsInCollatzSequenceSlow(startingNumber: numberToCheck);
                if (numberOfSteps > maximumNumberOfSteps)
                {
                    maximumNumberOfSteps = numberOfSteps;
                    valueWithMaximumNumberOfSteps = numberToCheck;
                }
                //Debug.WriteLine("{0} had {1} steps. Maximum is {2} with {3}", numberToCheck, numberOfSteps, valueWithMaximumNumberOfSteps, maximumNumberOfSteps);
            }

            return valueWithMaximumNumberOfSteps;
        }

        private static int GetNumberOfStepsInCollatzSequenceSlow(long startingNumber)
        {
            // numberOfSteps = 0
            // While startingNumber > 1
            // if startingNumber is even, divide by two
            // if startingNumber is odd, multiply by three
            // Add one to startingNumber.
            int numberOfSteps = 0;
            while (startingNumber > 1)
            {
                if (startingNumber % 2 == 0)
                {
                    startingNumber /= 2;
                }
                else
                {
                    startingNumber = (startingNumber * 3) + 1;
                }
                numberOfSteps++;
            }
            return numberOfSteps;
        }
    }
}
