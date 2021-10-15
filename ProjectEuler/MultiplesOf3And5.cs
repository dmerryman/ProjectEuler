using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class MultiplesOf3And5
    {
        public static int FindMultiplesOf3And5(int limit)
        {
            int multiplesSum = 0;
            for (int i = 3; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiplesSum += i;
                }
            }
            return multiplesSum;
        }
    }
}
