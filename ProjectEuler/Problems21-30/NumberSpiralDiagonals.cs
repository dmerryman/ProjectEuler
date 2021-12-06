using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            int[,] spiral = GenerateSpiral(size: size);
            int currSum = 0;
            for (int i = 0; i < size; i++)
            {
                currSum += spiral[i, i];
                currSum += spiral[size - i - 1, i];
            }

            currSum -= spiral[size / 2, size / 2];
            return currSum;
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
            int initialRun = 1;
            int cycleNumber = 0;
            int extraInterval = 0;
            while (currNumber < Math.Pow(x: size, y: 2))
            {
                cycleNumber++;
                currCol++;
                spiral[currRow, currCol] = currNumber;
                currNumber++;
                for (int i = 0; i <= (currInterval / 2) - initialRun + extraInterval; i++)
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
                    if (currInterval == 67)
                    {
                        int pause = 1;
                    }
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
                initialRun = 0;
                if (cycleNumber >= 2)
                {
                    extraInterval++;
                }
            }

            return spiral;
        }

        private static void PrintInOrder(int[,] spiral, int size)
        {
            for (int i = 0; i < size; i++)
            {
                bool printedThieLine = false;
                for (int j = 0; j < size; j++)
                {
                    if (spiral[i, j] != 0)
                    {
                        Debug.Write(spiral[i, j] + "\t");
                        printedThieLine = true;
                    }

                    if (printedThieLine)
                    {
                        Debug.WriteLine(String.Empty);
                    }
                }
            }
        }
    }
}
