using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems21_30
{
    public static class NamesScores
    {
        public static int FindNamesScores()
        {
            // Read in names.txt into an ArrayList.
            // Sort the arrayList alphabetically.
            // Find the score for each name.
                // Score is defined as the sum of the letter values (C = 3) multiplied by the name's position in the sorted list.
            // Find and return the sum of the score of every name in the arraylist.
            String[] names = SharedCode.InputHelper.ReadCSVInputNoQuotes(
                path: "C:\\Users\\dmerryman\\Documents\\repos\\ProjectEuler\\ProjectEuler\\Resources\\p022_names.txt");
            int sumOfScores = 0;
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                sumOfScores += GetNameScore(name: names[i], position: i);
            }

            return sumOfScores;
        }

        private static int GetNameScore(String name, int position)
        {
            int score = 0;
            char[] letters = name.ToCharArray();
            foreach (char c in letters)
            {
                score += (int)c - 64;
            }

            score *= (position + 1);
            return score;
        }
    }
}
