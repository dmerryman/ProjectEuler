using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class DistinctPowers
    {
        public static int FindDistinctPowers(int limit)
        {
            HashSet<BigInteger> distinctTerms = new HashSet<BigInteger>();
            for (int i = 2; i <= limit; i++)
            {
                BigInteger term = new BigInteger(i);
                for (int j = 2; j <= limit; j++)
                {
                    AddNewTerm(distinctTerms: distinctTerms, term: term, exponent: j);
                }
            }

            return distinctTerms.Count;
        }

        private static void AddNewTerm(HashSet<BigInteger> distinctTerms, BigInteger term, int exponent)
        {
            BigInteger result = BigInteger.Pow(value: term, exponent: exponent);
            if (!distinctTerms.Contains(item: result))
            {
                distinctTerms.Add(item: result);
            }
        }
    }
}
