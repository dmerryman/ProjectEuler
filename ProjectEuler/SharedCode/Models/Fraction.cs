using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.SharedCode.Models
{
    public class Fraction : IComparable<Fraction>, IEquatable<Fraction>
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new Exception("Division by zero");
            }
            Numerator = numerator;
            Denominator = denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Fraction otherFraction = (Fraction)obj;
                return (this.Numerator == otherFraction.Numerator && this.Denominator == otherFraction.Denominator);
            }
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(this.Numerator);
            hashCode.Add(this.Denominator);

            return hashCode.ToHashCode();
        }

        public int CompareTo(Fraction other)
        {
            int result;
            if (other.Denominator == this.Denominator && other.Numerator == this.Numerator)
            {
                result = 0;
            }
            else
            {
                result = decimal.Compare((decimal)this.Numerator / (decimal)this.Denominator,
                    (decimal)other.Numerator / (decimal)other.Denominator);
            }

            return result;
        }

        public bool Equals(Fraction other)
        {
            return (other != null && this.Numerator == other.Numerator && this.Denominator == other.Denominator);
        }

        public bool Reduce()
        {
            bool changed = false;
            List<int> numeratorFactors = SharedCode.Math.FindProperDivisorsOf(number: this.Numerator);
            List<int> denominatorFactors = SharedCode.Math.FindProperDivisorsOf(number: this.Denominator);
            List<int> commonFactors = new List<int>();
            foreach (int factor in numeratorFactors)
            {
                if (denominatorFactors.Contains(factor))
                {
                    commonFactors.Add(item: factor);
                }
            }

            foreach (int factor in commonFactors)
            {
                if (this.Numerator % factor == 0 && this.Denominator % factor == 0)
                {
                    this.Numerator /= factor;
                    this.Denominator /= factor;
                    changed = true;
                }
            }

            return changed;
        }
    }
}
