using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.SharedCode.Models
{
    public class NumericPermutation
    {
        public long number { get; private set; }

        public NumericPermutation(long numbericValue)
        {
            this.number = numbericValue;
        }
        public Dictionary<int, int> GetDigitCounts()
        {
            Dictionary<int, int> digitCountsDictionary = new Dictionary<int, int>();
            long tempnum = number;
            while (tempnum > 0)
            {
                int digit = (int)(tempnum % 10);
                if (!digitCountsDictionary.ContainsKey(key: digit))
                {
                    digitCountsDictionary.Add(key: digit, value: 1);
                }
                else
                {
                    digitCountsDictionary[digit]++;
                }

                tempnum /= 10;
            }

            return digitCountsDictionary;
        }

        public override bool Equals(object obj)
        {
            bool comparisonResult = true;
            if (obj == null || !this.GetType().Equals(o: obj.GetType()))
            {
                comparisonResult = false;
            }
            else
            {
                NumericPermutation otherNumericPermutation = (NumericPermutation)obj;
                Dictionary<int, int> thisDigitCounts = this.GetDigitCounts();
                Dictionary<int, int> otherDigitCounts = otherNumericPermutation.GetDigitCounts();
                if (thisDigitCounts.Keys.Count != otherDigitCounts.Keys.Count)
                {
                    comparisonResult = false;
                }

                if (comparisonResult)
                {
                    foreach (var thisPair in thisDigitCounts)
                    {
                        if (!otherDigitCounts.ContainsKey(key: thisPair.Key))
                        {
                            //Debug.WriteLine("{0} was not in the other", thisPair.Key);
                            comparisonResult = false;
                            break;
                        }

                        if (otherDigitCounts[thisPair.Key] != thisPair.Value)
                        {
                            //Debug.WriteLine("{0} didn't have the right number of occurances", thisPair.Key);
                            comparisonResult = false;
                            break;
                        }
                    }
                }
            }

            return comparisonResult;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            foreach (var pair in this.GetDigitCounts())
            {
                hashCode.Add(value: pair.Value * pair.Key);
            }

            return hashCode.ToHashCode();
        }
    }
}
