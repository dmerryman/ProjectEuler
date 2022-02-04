using System;
using System.Collections.Generic;
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
            int pause = 1;
            throw new NotImplementedException();
        }

        private static HashSet<int> GetValuesToCheck(List<int> triangularNumbers, List<int> squareNumbers,
            List<int> pentagonalNumbers, List<int> hexagonalNumbers, List<int> heptagonalNumbers,
            List<int> octagonalNumbers)
        {
            HashSet<int> valuesToCheck = new HashSet<int>();
            foreach (var value in triangularNumbers)
            {
                valuesToCheck.Add(item: value);
            }

            foreach (var value in squareNumbers)
            {
                valuesToCheck.Add(item: value);
            }

            foreach (var value in triangularNumbers)
            {
                valuesToCheck.Add(item: value);
            }

            return valuesToCheck;
        }

        private static List<int> GetTriangularNumbers(int limit)
        {
            List<int> triangularNumbers = new List<int>();
            int currNum = 1;
            int valueToAdd = 2;
            while (currNum < limit)
            {
                triangularNumbers.Add(item: currNum);
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
                squareNumbers.Add(item: currNum);
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
                pentagonalNumbers.Add(item: currNum);
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
                hexagonalNumbers.Add(item: currNum);
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
                heptagonalNumbers.Add(item: currNum);
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
                octagonalNumbers.Add(item: currNum);
                n++;
                currNum = (3 * n * n - 2 * n);
            }

            return octagonalNumbers;
        }
    }
}
