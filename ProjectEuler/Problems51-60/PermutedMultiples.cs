using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class PermutedMultiples
    {
        public static int FindPermutedMultiples(int numMultiplier)
        {
            // int currNum = 9 to track the current number we're checking
            // Loop while true
            // Get the digits in currNum.
            // for int i = 2 to numMultiplier
                // Check to see if currNum * i contains the same digits as currNum.
                    // If it doesn't, break and go to the next currNum.
                // When you find a number that this is true for from 2 to currNum, return that number.
            var currNum = 9;
            while (true)
            {
                if (currNum == 87124)
                {
                    int pause = 1;
                }
                var digitsInCurrNum = ProjectEuler.SharedCode.Math.GetDigits(value: currNum);
                var uniqueDigitsInCurrNum = digitsInCurrNum.ToHashSet();
                if (digitsInCurrNum.Count != uniqueDigitsInCurrNum.Count)
                {
                    currNum++;
                    continue;;
                }

                bool foundAnswer = true;
                for (var i = 2; i <= numMultiplier; i++)
                {
                    var multipliedNum = i * currNum;
                    var digitsFromMultipliedNum = ProjectEuler.SharedCode.Math.GetDigits(value: multipliedNum);
                    var uniqueDigitsFromMultipliedNum = digitsFromMultipliedNum.ToHashSet();
                    if (uniqueDigitsFromMultipliedNum.Count != digitsFromMultipliedNum.Count ||
                        uniqueDigitsFromMultipliedNum.Count != uniqueDigitsInCurrNum.Count)
                    {
                        foundAnswer = false;
                        break;
                    }

                    foreach (var digit in digitsFromMultipliedNum)
                    {
                        if (uniqueDigitsInCurrNum.Add(item: digit))
                        {
                            foundAnswer = false;
                            //Debug.WriteLine("{0} had different digits from {1}", multipliedNum, currNum);
                            break;
                        }
                        //Debug.WriteLine("{0} has the same digits as {1}", multipliedNum, currNum);
                    }
                }

                if (foundAnswer)
                {
                    break;
                }
                else
                {
                    currNum++;
                    continue;
                }
                
            }

            return currNum;
        }
    }
}
