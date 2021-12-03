using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class QuadraticPrimes
    {
        public static int FindQuadraticPrimes(int limit)
        {
            // Initialize largestNumConsecutivePrimes = Int.MinValue.
            // Initialize largestNumConsecutivePrimesA = Int.MinValue.
            // Initialize largestNumConsecutivePrimesB = Int.MinValue.
            // for (int a = -limit to limit)
            // for (int b = -limit to limit)
            // Initialize int n to 0.
            // Initliaze numConsecutivePrimes = 0.
            // Loop from n to infinity until f(x) is not prime
            // If f(x) is prime, incrememnt numConsecutivePrimes.
            // If f(x) is not prime, break out of the loop.
            // if numConsecutivePrimes > largestNumConsecutivePrimes, store that value, and A and B.
            // return largestNumConsecutivePrimesA * largestNumConsecutivePrimesB
            int largestNumConsecutivePrimes = Int32.MinValue;
            int largestNumConsecutivePrimesA = Int32.MinValue;
            int largestNumConsecutivePrimesB = Int32.MinValue;

            for (int a = -limit; a <= limit; a++)
            {
                for (int b = -limit; b <= limit; b++)
                {
                    int n = 0;
                    int numberOfConsecutivePrimes = 0;
                    bool isPrime = true;
                    while (isPrime)
                    {
                        int quadraticFormulaResult = QuadraticFormula(a: a, b: b, n: n);
                        isPrime = SharedCode.Math.IsItPrime(number: quadraticFormulaResult);
                        if (isPrime)
                        {
                            n++;
                            numberOfConsecutivePrimes++;
                        }
                    }

                    if (numberOfConsecutivePrimes > largestNumConsecutivePrimes)
                    {
                        largestNumConsecutivePrimes = numberOfConsecutivePrimes;
                        largestNumConsecutivePrimesA = a;
                        largestNumConsecutivePrimesB = b;
                    }
                }
            }

            return largestNumConsecutivePrimesA * largestNumConsecutivePrimesB;
        }

        public static int FindQuadraticPrimesSieve(int limit)
        {
            throw new NotImplementedException();
        }

        private static int QuadraticFormula(int a, int b, int n)
        {
            return (int)Math.Pow(x: n, y: 2) + (a * n) + b;
        }
    }
}
