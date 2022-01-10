using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems11_20;

namespace ProjectEuler.SharedCode
{
    public static class Strings
    {
        public static List<string> GetPermutations(string value)
        {
            List<string> permutations = new List<string>();
            char[] letters = value.ToCharArray();
            GetPermutationsHelper(permutations: permutations, letters: letters, k: 0, m: letters.Length - 1);
            return permutations;
        }

        private static void GetPermutationsHelper(List<string> permutations, char[] letters, int k, int m)
        {
            if (k == m)
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

        public static bool IsItAPalindrome(String s)
        {
            String testValue = s.ToUpper();
            for (int i = 0; i < testValue.Length / 2; i++)
            {
                if (testValue[i] != testValue[testValue.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static string wordChange(string value, int index)
        {
            string newValue = "";
            for (int i = 0; i < value.Length; i++)      
            {
                if (i == 0)
                {
                    newValue += value[index];
                }
                else if (i == index)
                {
                    newValue += value[0];
                }
                else
                {
                    newValue += value[i];
                }
            }

            return newValue;
        }
    }
}
