using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SpecialPythagoreanTriplet
    {
        public static int FindSpecialPythagoreanTripletBruteForce(int sum)
        {
            for (int i = 1; i < sum - 1; i++)
            {
                for (int j = 1; j < sum - 1; j++)
                {
                    if ((i * i) + (j * j) == (sum - i - j) * (sum - i - j))
                    {
                        return (i * j * (sum - i - j));
                    }
                }
            }

            throw new Exception("No triplet exists for this sum.");
        }

        public static int FindSpecialPythagoreanTripletBetter(int sum)
        {
            for (int i = 3; i < (sum - 3) / 3; i++)
            {
                for (int j = i + 1; j < (sum - 1 - i) / 2; j++)
                {
                    if ((i * i) + (j * j) == (sum - i - j) * (sum - i - j))
                    {
                        return (i * j * (sum - i - j));
                    }
                }
            }

            throw new Exception("No triplet exists for this sum.");
        }
    }
}
