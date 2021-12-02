using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class ReciprocalCycles
    {
        public static int FindReciprocalCycle(int d)
        {
            // Set a variable to track the longest reciprocating cycle, and set it to Int.MinValue.
            // Set a variable to track the position of the longest reciprocating cycle.
            // Loop for i from 2 to d - 1.
            // Calculate the length of the reciprocating cycle for 1 / i.
            // if the length of the reciprocating cycle is larger than the longest reciprocating cycle, store it, along with i.
            // return the position of the longest reciprocating cycle.
            int longestReciprocatingCycle = Int32.MinValue;
            int longestReciprocatingCyclePosition = Int32.MinValue;
            for (int i = 2; i < d; i++)
            {
                int currReciprocalyCycles = SharedCode.Math.GetLengthOfReciprocalCycle(numerator: 1, denominator: i);
                if (currReciprocalyCycles > longestReciprocatingCycle)
                {
                    longestReciprocatingCycle = currReciprocalyCycles;
                    longestReciprocatingCyclePosition = i;
                }
            }

            return longestReciprocatingCyclePosition;
        }
    }
}
