using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SmallestMultiple
    {
        public static int FindSmallestMultiple(int ceiling)
        {
            int currNum = FindStartingNum(ceiling: ceiling);
            bool foundNum = false;
            while (!foundNum)
            {
                foundNum = true;
                for (int i = 2; i <= ceiling; i++)
                {
                    if (currNum % i != 0)
                    {
                        foundNum = false;
                        break;
                    }
                }
                if (!foundNum)
                {
                    currNum += 2;
                }
            }
            return currNum;
        }

        private static int FindStartingNum(int ceiling)
        {
            if (ceiling % 2 != 0)
            {
                ceiling--;
            }
            return ceiling;
        }
    }
}
