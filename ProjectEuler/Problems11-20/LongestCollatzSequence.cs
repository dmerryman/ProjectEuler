using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems11_20
{
    public static class LongestCollatzSequence
    {
        public static int FindLongestCollatzSequenceSlowest(int ceiling)
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

        public static int FindLongestCollatzSequenceFast(int ceiling)
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

        public static int FindNumberOfStepsInCollatzSequenceFaster(int ceiling)
        {
            Dictionary<long, int> collatzSequence = new Dictionary<long, int>();
            collatzSequence.Add(key: 1, value: 1);
            int largestNumberOfSteps = int.MinValue;
            int valueWithLargestNumberOfSteps = int.MinValue;
            for (int i = ceiling / 2; i <= ceiling; i++)
            {
                int numberOfSteps = GetNumberOfStepsInCollatzSequenceFasterHelper(collatzDictionary: collatzSequence, value: i);
                if (numberOfSteps > largestNumberOfSteps)
                {
                    largestNumberOfSteps = numberOfSteps;
                    valueWithLargestNumberOfSteps = i;
                }
            }

            return valueWithLargestNumberOfSteps;
        }

        private static int GetNumberOfStepsInCollatzSequenceFasterHelper(Dictionary<long, int> collatzDictionary, long value)
        {
            if (collatzDictionary.ContainsKey(key: value))
            {
                return collatzDictionary[value];
            }

            if (value % 2 == 0)
            {
                collatzDictionary.Add(key: value, value: 1 + GetNumberOfStepsInCollatzSequenceFasterHelper(collatzDictionary: collatzDictionary, value: value / 2));
            }
            else
            {
                collatzDictionary.Add(key: value, value: 2 + GetNumberOfStepsInCollatzSequenceFasterHelper(collatzDictionary: collatzDictionary, value: (((value * 3) + 1) / 2)));
            }

            return collatzDictionary[value];
        }
    }
}
