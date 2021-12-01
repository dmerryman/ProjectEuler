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
                int currReciprocalyCycles = GetLengthOfReciprocalCycle(d: i);
                Debug.WriteLine("1 / {0} is {1} decimal places long.", i, currReciprocalyCycles);
            }
            throw new NotImplementedException();
        }

        public static int GetLengthOfReciprocalCycle(int d)
        {
            int numerator = 1;
            int denominator = d;
            int length = 0;
            while (length < 25)
            {
                bool alreadyIncreased = false;
                while (d > numerator)
                {
                    length++;
                    numerator *= 10;
                    alreadyIncreased = true;
                }

                int quotient = numerator / denominator;
                int remainder = numerator % denominator;
                //Debug.WriteLine("{0} // {1} = {2} R {3}", numerator, denominator, quotient, remainder);
                if (!alreadyIncreased)
                {
                    length++;
                }
                if (remainder == 0)
                {
                    break;
                }
                else
                {
                    numerator = remainder;
                }
            }

            return length;
        }
    }
}
