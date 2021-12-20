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
        public static int FindPentagonNumbers()
        {
            List<int> pentagonNumbers = GetPentagonNumbers(amount: 100000);
            int pause = 1;
            throw new NotImplementedException();
        }

        public static int GetPentagonNumber(int n)
        {
            return n * ((3 * n) - 1) / 2;
        }

        public static List<int> GetPentagonNumbers(int amount)
        {
            List<int> pentagonNumbers = new List<int>(amount);
            for (int i = 1; i <= amount; i++)
            {
                pentagonNumbers.Add(item: i * ((3 * i) - 1) / 2);
            }

            return pentagonNumbers;
        }

        public static bool IsSumPentagonal(List<int> pentagonNumbers, int num1, int num2)
        {
            return pentagonNumbers.Contains(item: num1 + num2);
        }

        public static bool IsDifferencePentagonal(List<int> pentagonNumbers, int num1, int num2)
        {
            return pentagonNumbers.Contains((int)(Math.Abs(num1 - num2)));
        }
    }
}
