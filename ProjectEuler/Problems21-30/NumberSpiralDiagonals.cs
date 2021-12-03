using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class NumberSpiralDiagonals
    {
        public static int FindNumberSpiralDiagnoals(int size)
        {
            // Create a 2 dimensional array of [size, size].
            // Initialize a variable for the current count, number = 1.
            // start with [size / 2, size / 2]
            // Go right 1, down currSize / 2, left currSize - 1, up currSize - 1, right currSize - 1,
            // incrementing number as you go. For each spiral completion, add 2 to currSize, with it starting at 3.
            int[,] spiral = new int[size, size];

            throw new NotImplementedException();
        }

        private static int[,] GenerateSpiral(int size)
        {
            throw new NotImplementedException();
        }
    }
}
