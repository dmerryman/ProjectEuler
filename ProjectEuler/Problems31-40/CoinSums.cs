using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class CoinSums
    {
        public static int FindCoinSums(int pounds, int pence)
        {
            return FindCoinSumsHelperBruteForce(pence: (pounds * 100) + pence);
        }

        public static int FindCoinSumsDP(int pounds, int pence)
        {
            return FindCoinSumsDPHelper(pence: (pounds * 100) + pence);
        }

        private static int FindCoinSumsDPHelper(int pence)
        {
            int[] coinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] numWaysArray = new int[pence + 1];
            numWaysArray[0] = 1;
            for (int i = 0; i < coinSizes.Length; i++)
            {
                for (int j = coinSizes[i]; j <= pence; j++)
                {
                    //Debug.WriteLine("Adding {0} from numWaysArray[{1}] to {2}  at numWaysArray[{3}] and now it's {4}",
                    //    numWaysArray[j - coinSizes[i]], j - coinSizes[i], numWaysArray[j], j,
                    //    numWaysArray[j] + numWaysArray[j - coinSizes[i]]);
                    numWaysArray[j] += numWaysArray[j - coinSizes[i]];
                }
            }

            return numWaysArray[pence];
        }

        private static int FindCoinSumsHelperBruteForce(int pence)
        {
            int numWays = 0;
            for (int num200 = pence; num200 >= 0; num200 -= 200)
            {
                for (int num100 = num200; num100 >= 0; num100 -= 100)
                {
                    for (int num50 = num100; num50 >= 0; num50 -= 50)
                    {
                        for (int num20 = num50; num20 >= 0; num20 -= 20)
                        {
                            for (int num10 = num20; num10 >= 0; num10 -= 10)
                            {
                                for (int num5 = num10; num5 >= 0; num5 -= 5)
                                {
                                    for (int num2 = num5; num2 >= 0; num2 -= 2)
                                    {
                                        numWays++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numWays;
        }

      
    }
}
