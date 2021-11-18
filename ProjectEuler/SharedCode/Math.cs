﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.SharedCode
{
    public static class Math
    {
        public static bool[] GeneratePrimeSieve(int limit)
        {
            // False indicates a prime number.
            bool[] sieve = new bool[limit];
            for (int i = 2; i < limit; i++)
            {
                if (!sieve[i])
                {
                    int multiple = 2;
                    int currNum = i * multiple;
                    while (currNum < limit)
                    {
                        sieve[currNum] = true;
                        multiple++;
                        currNum = i * multiple;
                    }
                }
            }
            return sieve;
        }

        public static bool IsItPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            else if (number < 4)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else if (number < 9)
            {
                return true;
            }
            else if (number % 3 == 0)
            {
                return false;
            }

            int ceiling = (int)System.Math.Sqrt(d: number);
            for (int i = 3; i <= ceiling; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> FindProperDivisorsOf(int number)
        {
            List<int> properDivisors = new List<int>();
            properDivisors.Add(item: 1);
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    properDivisors.Add(item: i);
                }
            }

            return properDivisors;
        }
    }
}
