using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class PandigitalProducts
    {
        public static int FindPandigitalProducts()
        {
            // int currSum to hold sum of pandigital products.
            // for int index = lower limit to upper limit
                // Calculate the factors of index
                // Loop through each combination of the factors of index.
                // Combine multiplicand, multiplier, and product, and check to see if its
                // pandigital.
                    // If it is, add index to currSum and break.
            // return currSum
            int currSum = 0;
            bool pandigitalProductConfirmed = false;
            for (int i = 1234; i <= 9876; i++)
            {
                List<int> factors = SharedCode.Math.FindProperDivisorsOf(number: i);
                pandigitalProductConfirmed = false;
                foreach (int factor1 in factors)
                {
                    foreach (int factor2 in factors)
                    {
                        if (IsPandigitalProduct(first: factor1, second: factor2, product: i))
                        {
                            currSum += i;
                            pandigitalProductConfirmed = true;
                            //Debug.WriteLine("{0} * {1} = {2} and it's a pandigital product.", factor1, factor2, i);
                            break;
                        }
                    }

                    if (pandigitalProductConfirmed)
                    {
                        break;
                    }
                }
            }

            return currSum;
        }

        public static int FindPandigitalProductsUnOptimized()
        {
            // int currSum to hold sum of pandigital products.
            // for int index = lower limit to upper limit
            // Calculate the factors of index
            // Loop through each combination of the factors of index.
            // Combine multiplicand, multiplier, and product, and check to see if its
            // pandigital.
            // If it is, add index to currSum and break.
            // return currSum
            int currSum = 0;
            bool pandigitalProductConfirmed = false;
            for (int i = 1234; i <= 9876; i++)
            {
                List<int> factors = SharedCode.Math.FindProperDivisorsOf(number: i);
                pandigitalProductConfirmed = false;
                foreach (int factor1 in factors)
                {
                    foreach (int factor2 in factors)
                    {
                        if (IsPandigitalProductUnOptimized(first: factor1, second: factor2, product: i))
                        {
                            currSum += i;
                            pandigitalProductConfirmed = true;
                            //Debug.WriteLine("{0} * {1} = {2} and it's a pandigital product.", factor1, factor2, i);
                            break;
                        }
                    }

                    if (pandigitalProductConfirmed)
                    {
                        break;
                    }
                }
            }

            return currSum;
        }

        public static bool IsPandigitalProduct(int first, int second, int product)
        {
            // Combine all three numbers into a string numString.
            // Cast numString as an int testNum
            // Create a HashSet<int> digits to hold individual digits.
            // Loop until testNum = 0.
            // Add testNum % 10 to digits if its not already there.
            // If that value is already in digits, return false.
            // Divide tetNum by 10.
            // Loop from int i = 1 to 9
            // If digits doesn't contain i, return false
            // return true
            if (first * second != product)
            {
                // This isn't even close to a solution.
                return false;
            }

            string numString = first.ToString() + second.ToString() + product.ToString();
            if (numString.Contains(value: "0") || numString.Length != 9)
            {
                return false;
            }
            HashSet<int> digits = new HashSet<int>();
            int testNum = Int32.Parse(s: numString);
            while (testNum != 0)
            {
                int digitToAdd = testNum % 10;
                if (digits.Contains(item: digitToAdd))
                {
                    return false;
                }

                digits.Add(item: digitToAdd);
                testNum /= 10;
            }
            return true;
        }

        public static bool IsPandigitalProductUnOptimized(int first, int second, int product)
        {
            // Combine all three numbers into a string numString.
            // Cast numString as an int testNum
            // Create a HashSet<int> digits to hold individual digits.
            // Loop until testNum = 0.
            // Add testNum % 10 to digits if its not already there.
            // If that value is already in digits, return false.
            // Divide tetNum by 10.
            // Loop from int i = 1 to 9
            // If digits doesn't contain i, return false
            // return true
            if (first * second != product)
            {
                // This isn't even close to a solution.
                return false;
            }

            string numString = first.ToString() + second.ToString() + product.ToString();
            HashSet<int> digits = new HashSet<int>();
            int testNum = Int32.Parse(s: numString);
            while (testNum != 0)
            {
                int digitToAdd = testNum % 10;
                if (digits.Contains(item: digitToAdd))
                {
                    return false;
                }

                digits.Add(item: digitToAdd);
                testNum /= 10;
            }

            for (int i = 1; i <= 9; i++)
            {
                if (!digits.Contains(i))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
