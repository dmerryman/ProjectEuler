using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems61_70
{
    public static class CyclicalFigurateNumbers
    {
        public static int FindCyclicalFigurateNumbers()
        {
            // int sumOfCyclicaFigurateNumbers = int32.maxvalue to track the sum of the cyclicak figurate numbers.
            // int[] cyclicalFigurateNumbers = new int[6] to track the cyclical figurate numbers.
            // Get A list of 4 digit values for triangle, square, pentagonal, hexagonal, heptagonal, and octragonal numbers
            List<int> triangularNumbers = GetTriangularNumbers(limit: 10000);
            List<int> squareNumbers = GetSquareNumbers(limit: 10000);
            List<int> pentagonalNumbers = GetPentagonalNumbers(limit: 10000);
            List<int> hexagonalNumbers = GetHexagonalNumbers(limit: 10000);
            List<int> heptagonalNumbers = GetHeptagonalNumbers(limit: 10000);
            List<int> octagonalNumbers = GetOctagonalNumbers(limit: 10000);
            HashSet<int> valuesToCheck = GetValuesToCheck(triangularNumbers: triangularNumbers,
                squareNumbers: squareNumbers, pentagonalNumbers: pentagonalNumbers, hexagonalNumbers: hexagonalNumbers,
                heptagonalNumbers: heptagonalNumbers, octagonalNumbers: octagonalNumbers);
            List<int> valuesSorted = valuesToCheck.ToList();
            valuesSorted.Sort();
            foreach (var triangularNum in triangularNumbers)
            {
                if (triangularNum % 100 == 0)
                {
                    continue;
                }
                foreach (var squareNum in squareNumbers)
                {
                    if (triangularNum == squareNum || squareNum % 100 == 0)
                    {
                        continue;
                    }
                    foreach (var pentagonalNum in pentagonalNumbers)
                    {
                        if (triangularNum == pentagonalNum || squareNum == pentagonalNum)
                        {
                            continue;
                        }
                        foreach (var hexagonalNum in hexagonalNumbers)
                        {
                            if (triangularNum == hexagonalNum || squareNum == hexagonalNum ||
                                pentagonalNum == hexagonalNum)
                            {
                                continue;
                            }
                            foreach (var heptagonalNum in heptagonalNumbers)
                            {
                                if (triangularNum == heptagonalNum || squareNum == heptagonalNum ||
                                    pentagonalNum == heptagonalNum || hexagonalNum == heptagonalNum)
                                {
                                    continue;
                                }
                                foreach (var octagonalNum in octagonalNumbers)
                                {
                                    if (triangularNum == octagonalNum || squareNum == octagonalNum ||
                                        pentagonalNum == octagonalNum || hexagonalNum == octagonalNum ||
                                        heptagonalNum == octagonalNum)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        int[] possibleCyclicalNums = new[]
                                        {
                                            triangularNum, squareNum, pentagonalNum, hexagonalNum, heptagonalNum,
                                            octagonalNum
                                        };
                                        if (IsCyclical6Values(valuesToCheck: possibleCyclicalNums))
                                        {
                                            Debug.WriteLine("{0}, {1}, {2}, {3}, {4}, {5} are cyclical.",
                                                                            possibleCyclicalNums[0], possibleCyclicalNums[1],
                                                                            possibleCyclicalNums[2], possibleCyclicalNums[3],
                                                                            possibleCyclicalNums[4], possibleCyclicalNums[5]);
                                            return triangularNum + squareNum + pentagonalNum + hexagonalNum +
                                                   heptagonalNum + octagonalNum;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //for (int i = 0; i < valuesSorted.Count - 5; i++)
            //{
            //    for (int j = i + 1; j < valuesSorted.Count - 4; j++)
            //    {
            //        for (int k = j + 1; k < valuesSorted.Count - 3; k++)
            //        {
            //            for (int l = k + 1; l < valuesSorted.Count - 2; l++)
            //            {
            //                for (int m = l + 1; m < valuesSorted.Count - 1; m++)
            //                {
            //                    for (int n = m + 1; n < valuesSorted.Count; n++)
            //                    {
            //                        int[] possibleCyclicalArray = new[]
            //                        {
            //                            valuesSorted[i], valuesSorted[j], valuesSorted[k], valuesSorted[l],
            //                            valuesSorted[m], valuesSorted[n]
            //                        };
            //                        if (IsCyclical6Values(valuesToCheck: possibleCyclicalArray))
            //                        {
            //                            Debug.WriteLine("{0}, {1}, {2}, {3}, {4}, {5} are cyclical.",
            //                                possibleCyclicalArray[0], possibleCyclicalArray[1],
            //                                possibleCyclicalArray[2], possibleCyclicalArray[3],
            //                                possibleCyclicalArray[4], possibleCyclicalArray[5]);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            int pause = 1;
            throw new NotImplementedException();
        }

        private static bool IsCyclical6Values(int[] valuesToCheck)
        {
            // divide by 100 to get first two digits.
            // % 100 to get the last two digits.
            bool returnValue = true;
            string debugLine = String.Empty;
            if (valuesToCheck.Length != 6)
            {
                return false;
            }

            for (int i = 0; i < valuesToCheck.Length - 1; i++)
            {
                if (valuesToCheck[i] % 100 != valuesToCheck[i + 1] / 100)
                {
                    if (!String.IsNullOrEmpty(debugLine))
                    {
                        Debug.WriteLine(debugLine);
                    }
                    return false;
                }
                else
                {
                    debugLine += valuesToCheck[i] + ", " + valuesToCheck[i + 1];
                }
            }

            if (valuesToCheck[valuesToCheck.Length - 1] % 100 != valuesToCheck[0] / 100)
            {
                return false;
            }
            return true;
        }

        private static HashSet<int> GetValuesToCheck(List<int> triangularNumbers, List<int> squareNumbers,
            List<int> pentagonalNumbers, List<int> hexagonalNumbers, List<int> heptagonalNumbers,
            List<int> octagonalNumbers)
        {
            HashSet<int> valuesToCheck = new HashSet<int>();
            foreach (var value in triangularNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            foreach (var value in squareNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            foreach (var value in triangularNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            foreach (var value in pentagonalNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            foreach (var value in hexagonalNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            foreach (var value in heptagonalNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            foreach (var value in octagonalNumbers)
            {
                if (Has4Digits(value: value))
                {
                    valuesToCheck.Add(item: value);
                }
            }

            return valuesToCheck;
        }

        private static bool Has4Digits(int value)
        {
            return value > 999 && value < 10000;
        }

        private static List<int> GetTriangularNumbers(int limit)
        {
            List<int> triangularNumbers = new List<int>();
            int currNum = 1;
            int valueToAdd = 2;
            while (currNum < limit)
            {
                if (Has4Digits(value: currNum))
                {
                    triangularNumbers.Add(item: currNum);
                }
                currNum += valueToAdd;
                valueToAdd++;
            }

            return triangularNumbers;
        }

        private static List<int> GetSquareNumbers(int limit)
        {
            List<int> squareNumbers = new List<int>();
            int currNum = 1;
            int numToSquare = 1;
            while (currNum < limit)
            {
                if (Has4Digits(value: currNum))
                {
                    squareNumbers.Add(item: currNum);
                }
                numToSquare++;
                currNum = (int)Math.Pow(x: numToSquare, y: 2);
            }

            return squareNumbers;
        }

        private static List<int> GetPentagonalNumbers(int limit)
        {
            List<int> pentagonalNumbers = new List<int>();
            int currNum = 1;
            int n = 1;
            while (currNum < limit)
            {
                if (Has4Digits(value: currNum))
                {
                    pentagonalNumbers.Add(item: currNum);
                }
                n++;
                currNum = currNum + (3 * n) - 2;
            }
            return pentagonalNumbers;
        }

        private static List<int> GetHexagonalNumbers(int limit)
        {
            List<int> hexagonalNumbers = new List<int>();
            int currNum = 1;
            int n = 1;
            while (currNum < limit)
            {
                if (Has4Digits(value: currNum))
                {
                    hexagonalNumbers.Add(item: currNum);
                }
                n++;
                currNum = n * ((2 * n) - 1);
            }

            return hexagonalNumbers;
        }

        private static List<int> GetHeptagonalNumbers(int limit)
        {
            List<int> heptagonalNumbers = new List<int>();
            int currNum = 1;
            int n = 1;
            while (currNum < limit)
            {
                if (Has4Digits(value: currNum))
                {
                    heptagonalNumbers.Add(item: currNum);
                }
                n++;
                currNum = ((5 * n * n) - (3 * n)) / 2;
            }

            return heptagonalNumbers;
        }

        private static List<int> GetOctagonalNumbers(int limit)
        {
            List<int> octagonalNumbers = new List<int>();
            int currNum = 1;
            int n = 1;
            while (currNum < limit)
            {
                if (Has4Digits(value: currNum))
                {
                    octagonalNumbers.Add(item: currNum);
                }
                n++;
                currNum = (3 * n * n - 2 * n);
            }

            return octagonalNumbers;
        }
    }
}
