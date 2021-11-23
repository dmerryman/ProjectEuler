using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class LexicographicPermutations
    {
        public static string FindLexicographicPermutations(int permutationNumber)
        {
            // Let's try the Factoradic method?
            String str = "0123456789";
            return sortedPermutations(str.ToCharArray(), permutationNumber);
        }

        public static string FindLexicographicPermutationsFactoradic(int permutationNumber)
        {
            String str = "0123456789";
            Stack<int> s = new Stack<int>();
            String result = String.Empty;

            // Subtracting 1 since permutations start from 0 with this method.
            permutationNumber--;
            // Loop to generate the factoroid of the sequence
            for (int i = 1; i < str.Length + 1; i++)
            {
                s.Push(permutationNumber % i);
                permutationNumber /= i;
            }

            // Loop to generate nth permutation.
            for (int i = 0; i < str.Length; i++)
            {
                int a = s.Peek();
                result += str[a];
                Debug.WriteLine("{0} after appending {1}", result, str[a]);
                int j;
                // Remove 1-element in each cycle.
                for (j = a; j < str.Length - 1; j++)
                {
                    str = str.Substring(0, j) + str[j + 1] + str.Substring(j + 1);
                }

                str = str.Substring(0, j + 1);
                s.Pop();
            }

            return result;
        }



        private static void swap(char[] str, int i, int j)
        {
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }

        private static void reverse(char[] str, int i, int j)
        {
            while (i < j)
            {
                swap(str, i, j);
                i++;
                j--;
            }
        }

        private static int FindCell(char[] str, char first, int l, int h)
        {
            int cellIndex = l;

            for (int i = l + 1; i <= h; i++)
            {
                if (str[i] > first && str[i] < str[cellIndex])
                {
                    cellIndex = i;
                }
            }

            return cellIndex;
        }

        private static string sortedPermutations(char[] str, int numPermutations)
        {
            int size = str.Length;
            int currNumPermutations = 1;
            Array.Sort(str);
            Boolean isFinished = false;
            while (!isFinished && currNumPermutations < numPermutations)
            {
                currNumPermutations++;
                int i = size - 2;
                for (i = size - 2; i >= 0; --i)
                {
                    if (str[i] < str[i + 1])
                    {
                        break;
                    }
                }

                if (i == -1)
                {
                    isFinished = true;
                }
                else
                {
                    int cellIndex = FindCell(str, str[i], i + 1, size - 1);
                    swap(str, i, cellIndex);
                    reverse(str, i + 1, size - 1);
                }
            }

            return new string(str);
        }
    }
}
