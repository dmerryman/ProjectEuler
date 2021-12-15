using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems31_40
{
    public static class IntegerRightTriangles
    {
        public static int FindIntegerRightTriangles(int perimeterLimit)
        {
            // int maxNumberOfSolutions = Int32.MinValue to track maximum number of solutions.
            // for int perimiter = 2 to limit
                // int currNumberOfSolutions = 0 to track current number of solutions.
                // for int a = 1 to perimiter
                    // for int b = 1 to a
                        // for int c = 1 to perimeter.
                            // check to see if this is a solution.
                                // if it is, incrememnt currNumberOfSolutions by one and break.
                // check if currNumberOfSolutions > maxNumberOfSolutions
                    // if so, set maxNumberOfSolutions = currNumberOfSolutions
            // return maxNumberOfSolutions
            int maxNumberOfSolutions = Int32.MinValue;
            int perimeterWithMostSolutions = -1;
            for (int perimeter = 4; perimeter <= perimeterLimit; perimeter += 2)
            {
                int currNumberOfSolutions = 0;
                for (int c = 2; c <= perimeter - 2; c++)
                {
                    for (int b = 1; b <= perimeter - c; b++)
                    {
                        for (int a = 1; a <= perimeter - c - b; a++)
                        {
                            if (a + b + c == perimeter)
                            {
                                if (Math.Pow(x: a, y: 2) + Math.Pow(x: b, y: 2) == Math.Pow(x: c, y: 2))
                                {
                                    //Debug.WriteLine(
                                    //    "{0} + {1} + {2} = {3} is a solution. {4} is the current best perimeter.", a, b,
                                    //    c, perimeter, perimeterWithMostSolutions);
                                    currNumberOfSolutions++;
                                }
                            }
                        }
                    }
                }

                if (currNumberOfSolutions > maxNumberOfSolutions)
                {
                    maxNumberOfSolutions = currNumberOfSolutions;
                    perimeterWithMostSolutions = perimeter;
                }
            }

            return perimeterWithMostSolutions;
        }
    }
}
