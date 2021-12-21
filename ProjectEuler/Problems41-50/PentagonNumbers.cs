using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems41_50
{
    public static class PentagonNumbers
    {
        public static long FindPentagonNumbers()
        {
            long smallestDifference = long.MaxValue;
            long smallestPairFirstNum = -1;
            long smallestPairSecondNum = -1;
            List<long> pentagonNumbers = GetPentagonNumbers(amount: 2500);
            long[] pentagonNumbersArray = pentagonNumbers.ToArray();
            for (int i = 0; i < pentagonNumbersArray.Length; i++)
            {
                for (int j = i; j < pentagonNumbersArray.Length; j++)
                {
                    if (IsSumPentagonal(pentagonNumbers: pentagonNumbers, num1: pentagonNumbersArray[i], num2: pentagonNumbersArray[j]))
                    {
                        if (IsDifferencePentagonal(pentagonNumbers: pentagonNumbers, num1: pentagonNumbersArray[i], num2: pentagonNumbersArray[j]))
                        {
                            if (Math.Abs(pentagonNumbersArray[i] - pentagonNumbersArray[j]) < smallestDifference)
                            {
                                smallestPairFirstNum = pentagonNumbersArray[i];
                                smallestPairSecondNum = pentagonNumbersArray[j];
                                smallestDifference = Math.Abs(pentagonNumbersArray[i] - pentagonNumbersArray[j]);
                                Debug.WriteLine("{0} and {1} is a solution, and their difference is {2}",
                                    smallestPairFirstNum, smallestPairSecondNum, smallestDifference);
                            }
                        }
                    }
                }
            }
            return smallestDifference;
        }

        public static long FindPentagonNumbersWithSieve()
        {
            int limit = (int)GetPentagonNumber(n: 2500);
            long smallesDifference = long.MaxValue;
            bool[] pentagonalSieve = GeneratePentagonalSieve(limit: limit);
            for (int i = 0; i < pentagonalSieve.Length; i++)
            {
                if (!pentagonalSieve[i])
                {
                    continue;
                }
                for (int j = i + 1; j < pentagonalSieve.Length; j++)
                {
                    if (!pentagonalSieve[j] || i + j >= pentagonalSieve.Length)
                    {
                        continue;
                    }
                    else if (pentagonalSieve[i + j] && pentagonalSieve[Math.Abs(value: i - j)])
                    {
                        if ((i + j) < smallesDifference)
                        {
                            smallesDifference = Math.Abs(i - j);
                        }
                    }
                }
            }

            return smallesDifference;
        }

        private static bool[] GeneratePentagonalSieve(int limit)
        {
            bool[] pentagonalSieve = new bool[limit + 1];
            for (int i = 1; i <= 2500; i++)
            {
                pentagonalSieve[GetPentagonNumber(n: i)] = true;
            }

            return pentagonalSieve;
        }

        private static long GetPentagonNumber(int n)
        {
            return n * ((3 * n) - 1) / 2;
        }

        private static List<long> GetPentagonNumbers(int amount)
        {
            List<long> pentagonNumbers = new List<long>(amount);
            for (int i = 1; i <= amount; i++)
            {
                pentagonNumbers.Add(item: i * ((3 * i) - 1) / 2);
            }

            return pentagonNumbers;
        }

        private static bool IsSumPentagonal(List<long> pentagonNumbers, long num1, long num2)
        {
            return pentagonNumbers.Contains(item: num1 + num2);
        }

        private static bool IsDifferencePentagonal(List<long> pentagonNumbers, long num1, long num2)
        {
            return pentagonNumbers.Contains((int)(Math.Abs(num1 - num2)));
        }
    }
}
