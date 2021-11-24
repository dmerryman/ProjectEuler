using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.SharedCode
{
    public class BigNumber
    {
        private int[] number;
        public BigNumber(String number)
        {
            if (!BigNumber.IsNumeric(number: number))
            {
                throw new Exception("Not a number");
            }
            this.number = new int[number.Length];
            char[] digits = number.ToCharArray();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                this.number[i] = (int)Char.GetNumericValue(digits[i]);
            }
            TrimLeadingZeroes();
        }

        private BigNumber(int[] digits)
        {
            number = digits;
            Carry();
            TrimLeadingZeroes();
        }

        public BigNumber Addition(BigNumber otherNumber)
        {
            int numDigits = 0;
            if (this.GetNumberOfDigits() > otherNumber.GetNumberOfDigits())
            {
                numDigits = this.GetNumberOfDigits();
            }
            else
            {
                numDigits = otherNumber.GetNumberOfDigits();
            }
            int[] newNumber = new int[numDigits + 1];

            int newNumberIndex = newNumber.Length - 1;
            for (int i = this.number.Length - 1; i >= 0; i--)
            {
                newNumber[newNumberIndex] = this.number[i];
                newNumberIndex--;
            }

            newNumberIndex = newNumber.Length - 1;
            for (int i = otherNumber.number.Length - 1; i >= 0; i--)
            {
                newNumber[newNumberIndex] += otherNumber.number[i];
                newNumberIndex--;
            }

            return new BigNumber(digits: newNumber);
        }

        public BigNumber Multiplication(BigNumber otherNumber)
        {
            throw new NotImplementedException();
        }

        public static bool IsNumeric(String number)
        {
            foreach (char c in number.ToCharArray())
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public override String ToString()
        {
            String returnString = String.Empty;
            bool startedNonZeroes = false;
            for (int i = 0; i < number.Length; i++)
            {
                returnString += number[i];
            }
            return returnString;
        }

        private void TrimLeadingZeroes()
        {
            bool startedNonZeroes = false;
            String value = String.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 0 && startedNonZeroes)
                {
                    value += number[i];
                }
                else if (number[i] != 0)
                {
                    value += number[i];
                    startedNonZeroes = true;
                }
            }

            if (value.Length != number.Length)
            {
                this.number = new int[value.Length];
                char[] digits = value.ToCharArray();
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    this.number[i] = (int)Char.GetNumericValue(digits[i]);
                }
            }
        }

        public int GetNumberOfDigits()
        {
            return number.Length;
        }

        private void Carry()
        {
            for (int i = number.Length - 1; i > 0; i--)
            {
                if (number[i] >= 10)
                {
                    int numToCarry = number[i] / 10;
                    number[i] = number[i] % 10;
                    number[i - 1] += numToCarry;
                }
            }
        }
    }
}
