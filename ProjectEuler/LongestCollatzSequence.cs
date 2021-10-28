using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class LongestCollatzSequence
    {
        public static int FindLongestCollatzSequence(int ceiling)
        {
            // From 1 to ceiling, go through the number of steps in each Collatz sequence, and get the number of steps involved.
            // For each number of steps, check if it exceeds the value of the previous maximum, and if so, set the maximum to be that value.
            // Return the maximum value
            throw new NotImplementedException();
        }

        private static int GetNumberOfStepsInCollatzSequence(int startingNumber)
        {
            throw new NotImplementedException();
        }
    }
}
