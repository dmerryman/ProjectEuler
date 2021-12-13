using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.SharedCode
{
    public static class Strings
    {
        public static List<string> GetPermutations(string value)
        {
            List<string> permutations = new List<string>();
            for (int i = 0; i < value.Length; i++)
            {
                char start = value[0];
                for (int j = 1; j < value.Length; j++)
                {
                    string left = value.Substring(1, j - 1);
                    string right = value.Substring(j);
                    //Debug.WriteLine(start + right + left);
                    permutations.Add(item: start + right + left);
                }

                if (i + 1 < value.Length)
                {
                    value = wordChange(value: value, index: i + 1);
                }
            }

            return permutations;
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
