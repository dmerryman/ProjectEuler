using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class LatticePaths
    {
        public static long FindLatticePathsSlowest(int squareSize)
        {
            return FindLatticePathSlowestHelper(squareSize, squareSize);
        }

        private static long FindLatticePathSlowestHelper(int i, int j)
        {
            if (i == 0 || j == 0)
            {
                return 1;
            }
            return FindLatticePathSlowestHelper(i, j - 1) + FindLatticePathSlowestHelper(j - 1, i);
        }

        public static long FindLatticePathsRecursive(int squareSize)
        {
            long[,] lattice = new long[squareSize + 1, squareSize + 1];
            return FindLatticePathsRecursiveHelper(i: squareSize, j: squareSize, lattice: lattice);
            throw new NotImplementedException();
        }

        private static long FindLatticePathsRecursiveHelper(int i, int j, long[,] lattice)
        {
            if (i == 0 || j == 0)
            {
                lattice[i, j] = 1;
                return lattice[i, j];
            }

            if (lattice[i, j] != 0)
            {
                return lattice[i, j];
            }
            long thisOne = FindLatticePathsRecursiveHelper(i: i, j: j - 1, lattice: lattice) +
                           FindLatticePathsRecursiveHelper(i: i - 1, j: j, lattice: lattice);
            lattice[i, j] = thisOne;
            return thisOne;
        }

        public static long FindLatticePathsIterative(int squareSize)
        {
            long[,] lattice = new long[squareSize + 1, squareSize + 1];
            for (int i = 0; i < squareSize; i++)
            {
                lattice[i, squareSize] = 1;
                lattice[squareSize, i] = 1;
            }

            for (int i = squareSize - 1; i >= 0; i--)
            {
                for (int j = squareSize - 1; j >= 0; j--)
                {
                    lattice[i, j] = lattice[i + 1, j] + lattice[i, j + 1];
                }
            }
            return lattice[0, 0];
        }
    }
}
