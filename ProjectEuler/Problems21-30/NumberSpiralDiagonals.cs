using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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
            int[,] spiral = GenerateSpiral(size: size);

            throw new NotImplementedException();
        }

        public static int FindNumberSpiralDiagonalsNoSpiral(int size)
        {
            int currSum = 1;
            int currNumber = 1;
            int currInterval = 2;
            while (currNumber < Math.Pow(x: size, y: 2))
            {
                for (int i = 0; i < 4; i++)
                {
                    currNumber += currInterval;
                    currSum += currNumber;
                }

                currInterval += 2;
            }

            return currSum;
        }

        private static int[,] GenerateSpiral(int size)
        {
            int[,] spiral = new int [size, size];
            int currNumber = 1;
            int currCol = size / 2;
            int currRow = size / 2;
            spiral[currRow, currCol] = currNumber;
            int currInterval = 3;
            currNumber++;
            while (currNumber < Math.Pow(x: size, y: 2))
            {
                currCol++;
                spiral[currRow, currCol] = currNumber;
                currNumber++;
                Debug.WriteLine("{0}", currInterval / 2);
                for (int i = 0; i <= currInterval / 2; i++)
                {
                    currRow++;
                    spiral[currRow, currCol] = currNumber;
                    currNumber++;
                }

                for (int i = 0; i < currInterval - 1; i++)
                {
                    currCol--;
                    spiral[currRow, currCol] = currNumber;
                    currNumber++;
                }

                for (int i = 0; i < currInterval - 1; i++)
                {
                    currRow--;
                    spiral[currRow, currCol] = currNumber;
                    currNumber++;
                }

                for (int i = 0; i < currInterval - 1; i++)
                {
                    currCol++;
                    spiral[currRow, currCol] = currNumber;
                    currNumber++;
                }

                currInterval += 2;
            }

            return spiral;
        }
    }
}
