using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems61_70
{
    public static class CyclicalFigurateNumbers
    {
        public static int FindCyclicalFigurateNumbers()
        {
            int sumOfValues = Int32.MaxValue;

            int[] solution = new int[6];
            int[][] numbers = new int[6][];

            // Getting lists of numbers.
            for (int i = 0; i < 6; i++)
            {
                numbers[i] = generateNumbers(type: i);
            }

            for (int i = 0; i < numbers[5].Length; i++)
            {
                // Starting with the last octagonal number.
                solution[5] = numbers[5][i];
                if (FindNext(last: 5, length: 1, solution: solution, numbers: numbers))
                {
                    break;
                }
            }

            Debug.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", solution[0], solution[1], solution[2], solution[3],
                solution[4], solution[5]);
            sumOfValues = solution.Sum();
            int pause = 1;
            return sumOfValues;
        }

        private static void WriteStatus(int[] solution)
        {
            Debug.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", solution[0], solution[1], solution[2], solution[3],
                solution[4], solution[5]);
        }

        private static bool FindNext(int last, int length, int[] solution, int[][] numbers)
        {
            // Looping through each element of solution.
            for (int i = 0; i < solution.Length; i++)
            {
                // Looping until we get to the first 0 element.
                if (solution[i] != 0)
                {
                    continue;
                }

                for (int j = 0; j < numbers[i].Length; j++)
                {
                    // Checking next value in numbers[i].
                    bool unique = true;
                    for (int k = 0; k < solution.Length; k++)
                    {
                        // Checking each number in solution to make sure numbers[i][j] isn't there yet.
                        if (numbers[i][j] == solution[k])
                        {
                            unique = false;
                            break;
                        }
                    }

                    if (unique)
                    {
                        // numbers[i][j] is not in the solution yet.
                        //Debug.WriteLine("Checking to see if {0} fits with {1}", numbers[i][j], solution[last]);
                        if (((numbers[i][j] / 100) == (solution[last] % 100)))
                        {
                            // numbers[i][j] meshes with the value in solution[last].
                            //Debug.WriteLine("A match! {0} fits with {1}", numbers[i][j], solution[last]);
                            // Adding this value to solution.
                            solution[i] = numbers[i][j];
                            // If this is the last value in the set, we should check to see if it loops
                            // back around to the first one we placed.
                            if (length == 5)
                            {
                                if (solution[5] / 100 == solution[i] % 100)
                                {
                                    // solution has been found.
                                    return true;
                                }
                            }

                            // Proceeding to the next slot in solution.
                            if (FindNext(last: i, length: length + 1, solution: solution, numbers: numbers))
                            {
                                // solution has been found.
                                return true;
                            }
                        }
                    }
                }
                // No next value was found for thevalue in solution[i], so we're gonna go back.

                solution[i] = 0;
                
            }
            // not done yet.
            return false;
        }

        private static int[] generateNumbers(int type)
        {
            List<int> numbers = new List<int>();
            int n = 0;
            int currNumber = 0;
            while (currNumber < 10000)
            {
                n++;
                switch (type)
                {
                    case 0:
                        currNumber = n * (n + 1) / 2;
                        break;
                    case 1:
                        currNumber = n * n;
                        break;
                    case 2:
                        currNumber = n * (3 * n - 1) / 2;
                        break;
                    case 3:
                        currNumber = n * (2 * n - 1);
                        break;
                    case 4:
                        currNumber = n * (5 * n - 3) / 2;
                        break;
                    case 5:
                        currNumber = n * (3 * n - 2);
                        break;
                }

                if (currNumber > 999 && currNumber < 10000)
                {
                    numbers.Add(item: currNumber);
                }
            }

            return numbers.ToArray();
        }

        
    }
}
