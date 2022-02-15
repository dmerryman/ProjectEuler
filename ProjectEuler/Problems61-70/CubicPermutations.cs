using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.SharedCode.Models;

namespace ProjectEuler.Problems61_70
{
    public static class CubicPermutations
    {
        public static long FindCubicPermutationsNew(int numPermutations)
        {
            List<long> cubicNumbersList = new List<long>();
            int maxNumPermutations = 1;
            long valueWithMaxPermutations = 1;
            int numValuesChecked = 0;
            for (long i = 1; i < 12000; i++)
            {
                long currCubicNum = i * i * i;
                cubicNumbersList.Add(item: currCubicNum);
            }

            var keys = cubicNumbersList.ToArray();
            for (int i = 0; i < keys.Length - 1; i++)
            {
                int currNumPermutations = 1;
                for (int j = i + 1; j < keys.Length; j++)
                {
                    NumericPermutation firstNum = new NumericPermutation(keys[i]);
                    NumericPermutation secondNum = new NumericPermutation(keys[j]);
                    if (firstNum.Equals(secondNum))
                    {
                        currNumPermutations++;
                    }
                }

                if (currNumPermutations > maxNumPermutations)
                {
                    maxNumPermutations = currNumPermutations;
                    valueWithMaxPermutations = keys[i];
                }

                //Debug.WriteLine("{0} has {1} cubic permutations. So far, {2} had the most cubic permutations with {3}",
                //    keys[i], currNumPermutations, valueWithMaxPermutations, maxNumPermutations);
                if (currNumPermutations == numPermutations)
                {
                    return keys[i];
                }
            }
            throw new NotImplementedException();
        }

        public static long FindCubicPermutations(int numPermutations)
        {
            // Get a list of cubic numbers from 1 to something.
            // Foreach cubic number, c
                // Get a list of permutations of this number.
                // int currNumCubicPermutations = 0 to track the current number of cubic numbers.
                // For each permutation
                    // Check to see if this number is cubic.
                        // if it is, incrememnt currNumCubicPermutations by 1.
                // Check to see if currNumCubicPermutations is == numPermutations
                    // If it is, return the smallest cubic number in that set (this cubic number)
            //HashSet<long> cubicNumbers = new HashSet<long>();
            Dictionary<long, bool> cubicNumbersDictionary = new Dictionary<long, bool>();
            int maxNumPermutations = 0;
            int numValuesCheck = 0;
            for (long i = 1; i < 4000; i++)
            {
                long currCubicNum = i * i * i;
                cubicNumbersDictionary.Add(key: currCubicNum, false);
                //cubicNumbers.Add(item: currCubicNum);
            }

            int pause = 1;




            var cubicNumbersKeys = cubicNumbersDictionary.Keys.ToList();

            for (int i = 0; i < cubicNumbersKeys.Count; i++)
            {
                //Debug.WriteLine("Checking {0}. Max num permutations is {1}", cubicNumbersKeys[i], maxNumPermutations);
                int currNumPermutations = 0;
                //int currNumDigits = SharedCode.Math.GetNumberOfDigits(value: cubicNumbersKeys[i]);
                if (!cubicNumbersDictionary[cubicNumbersKeys[i]])
                {
                    cubicNumbersDictionary[cubicNumbersKeys[i]] = true;
                    numValuesCheck++;
                    var permutations = GetCubicPermutations(value: cubicNumbersKeys[i].ToString()).ToHashSet();
                    foreach (var perm in permutations)
                    {
                        long numToCheck = long.Parse(s: perm);
                        if (cubicNumbersKeys.Contains(item: numToCheck))
                        {
                            //Debug.WriteLine("{0} is a cubic permutation of {1}.", numToCheck, cubicNumbersKeys[i]);
                            currNumPermutations++;
                            cubicNumbersDictionary[numToCheck] = true;
                        }
                    }

                    if (currNumPermutations > maxNumPermutations)
                    {
                        maxNumPermutations = currNumPermutations;
                    }

                    if (currNumPermutations == numPermutations)
                    {
                        int pause3 = 1;
                        return cubicNumbersKeys[i];
                    }
                }
            }

            int pause2 = 2;
            throw new NotImplementedException();
        }

        private static List<string> GetCubicPermutations(string value)
        {
            List<string> permutations = new List<string>();
            char[] letters = value.ToCharArray();
            GetPermutationsHelper(permutations: permutations, letters: letters, k: 0, m: letters.Length - 1);
            return permutations;
        }

        private static void GetPermutationsHelper(List<string> permutations, char[] letters, int k, int m)
        {
            if (k == m && letters[0] != '0')
            {
                permutations.Add(new string(value: letters));
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref letters[k], ref letters[i]);
                    GetPermutationsHelper(permutations: permutations, letters: letters, k: k + 1, m: m);
                    Swap(ref letters[k], ref letters[i]);
                }
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b)
            {
                return;
            }

            var temp = a;
            a = b;
            b = temp;
        }
    }
}
