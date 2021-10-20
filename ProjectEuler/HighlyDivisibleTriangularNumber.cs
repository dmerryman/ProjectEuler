using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class HighlyDivisibleTriangularNumber
    {
        public static int FindHighlyDivisibleTriangularNumber(int numDivisors)
        {
            int currNum = 1;
            int currNumToAdd = 1;
            while (FindNumberOfDivisors(number: currNum) <= 500)
            {
                currNumToAdd++;
                currNum += currNumToAdd;
            
            return currNum;
        }

        private static int FindNumberOfDivisors(int number)
        {
            throw new NotImplementedException();
        }
    }
}
