using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class PandigitalMultiples
    {
        public static int FindPandigitalMultiples()
        {
            // int largestPandigitalMultiple = int32.minvalue to track the largest pandigital multiple.
            // loop for int testValue from 1 to 98765432
            // Determeine if testValue is a pandigital multiple.
                // If it is, check to see if it's larger than largestPandigitalMultiple
                    // if it is, set largestPandigitalMultiple to that value.
            // return largestPandigitalMultiple
            throw new NotImplementedException();
        }

        private static bool IsItAPandigitalMultiple(int testValue)
        {
            // int Hash<int> digitsAccountedFor to track digits currently accounted for.
            // int currentMultiplier = 1 to track current multiplier.
            // Loop until digitsAccountedFor.Count == 9
                // multiply testValue by currentMultiplier and add each digit to digitsAccountedFor.
                // If a duplicate is found, then this is not a pandigital multiple, so return false.
            // return true.
            throw new NotImplementedException();
        }

        private static int GetPandigitalMultiple(int testValue)
        {
            int i = 1;
            int panDigitalMultiple = 0;
            int totalNumDigits = 0;

            while (totalNumDigits < 9)
            {
                int valueToAdd = testValue * i;
                int currNumDigits = SharedCode.Math.GetNumberOfDigits(value: valueToAdd);
                panDigitalMultiple += valueToAdd * (int)Math.Pow(x: 10, y: 9 - currNumDigits - totalNumDigits);
                totalNumDigits += SharedCode.Math.GetNumberOfDigits(value: testValue);
                i++;
            }
            return panDigitalMultiple;
        }

    }
}
