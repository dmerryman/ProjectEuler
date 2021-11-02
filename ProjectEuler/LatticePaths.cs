using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class LatticePaths
    {
        public static long FindLatticePathsSlowest(int squareSize)
        {
            return FindLatticePathHelper(squareSize, squareSize);
        }

        private static long FindLatticePathHelper(int i, int j)
        {
            if (i == 0 || j == 0)
            {
                return 1;
            }
            return FindLatticePathHelper(i, j - 1) + FindLatticePathHelper(j - 1, i);
        }
    }
}
