using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo(assemblyName: "ProjectEuler.Problems1_10")]
namespace ProjectEuler.Problems31_40
{
    public static class TrunctablePrimes
    {
        public static int FindTrunctablePrimes()
        {
            // int numTrunctablePrimes = 0 to track the number of trunctable primes.
            // int sumTrunctablePrimes = 0 to track the sum of trunctable primes.
            // Loop until numTrunctablePrimes == 11
                // Check if a number is prime.
                    // if it is, get a list of each possible variation of the number, and check to see if they're prime.
                    // if they all are, increment numTrunctablePrimes by one, and add the number to 
                    // sumTrunctablePrimes.
            // return sumTrunctablePrimes.
            int numTrunctablePrimns = 0;
            int sumTrunctablePrimes = 0;
            int currNum = 11;
            while (numTrunctablePrimns < 11)
            {
                if (SharedCode.Math.IsItPrime(number: currNum))
                {
                    if (IsItATrunctablePrime(value: currNum))
                    {
                        numTrunctablePrimns++;
                        sumTrunctablePrimes += currNum;
                        Debug.WriteLine("{0} is a trunctable prime.", currNum);
                    }
                }

                currNum += 2;
            }

            return sumTrunctablePrimes;
        }

        public static int FindTrunctablePrimesWithSieve()
        {
            bool[] primeSieve = SharedCode.Math.GeneratePrimeSieve(limit: 1000000);
            int numTrunctablePrimns = 0;
            int sumTrunctablePrimes = 0;
            int currNum = 11;
            while (numTrunctablePrimns < 11)
            {
                if (currNum == 11)
                {
                    int pause = 1;
                }
                if (!primeSieve[currNum])
                {
                    if (IsItATrunctablePrimeWithSieve(primeSieve: primeSieve, value: currNum))
                    {
                        numTrunctablePrimns++;
                        sumTrunctablePrimes += currNum;
                        //Debug.WriteLine("{0} is a trunctable prime.", currNum);
                    }
                }

                currNum += 2;
            }

            return sumTrunctablePrimes;
        }

        private static bool IsItATrunctablePrimeWithSieve(bool[] primeSieve, int value)
        {
            List<int> variations = GetNumberVariations(value: value);
            foreach (var testNumber in variations)
            {
                if (primeSieve[testNumber])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsItATrunctablePrime(int value)
        {
            List<int> variations = GetNumberVariations(value: value);
            foreach (var testNumber in variations)
            {
                if (!SharedCode.Math.IsItPrime(number: testNumber))
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> GetNumberVariations(int value)
        {
            int numberOfDigits = SharedCode.Math.GetNumberOfDigits(value: value);
            List<int> numberVariations = new List<int>();
            int tempValue = value;
            while (tempValue > 0)
            {
                numberVariations.Add(item: tempValue);
                tempValue /= 10;
            }

            tempValue = value;
            for (int i = 1; i < numberOfDigits; i++)
            {
                numberVariations.Add(item: tempValue % (int)Math.Pow(x: 10, y: i));
            }

            return numberVariations;
        }
    }
}
