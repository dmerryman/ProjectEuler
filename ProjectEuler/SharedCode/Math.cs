using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.SharedCode.Models;

namespace ProjectEuler.SharedCode
{
    public static class Math
    {
        public static bool[] GeneratePrimeSieve(int limit)
        {
            // False indicates a prime number.
            bool[] sieve = new bool[limit];
            sieve[0] = true;
            sieve[1] = true;
            for (int i = 2; i < limit; i++)
            {
                if (!sieve[i])
                {
                    int multiple = 2;
                    int currNum = i * multiple;
                    while (currNum < limit)
                    {
                        sieve[currNum] = true;
                        multiple++;
                        currNum = i * multiple;
                    }
                }
            }
            return sieve;
        }

        public static List<int> GeneratePrimeList(int limit)
        {
            bool[] sieve = new bool[limit + 1];
            sieve[1] = true;
            for (int i = 2; i < limit + 1; i++)
            {
                if (!sieve[i])
                {
                    int multiple = 2;
                    int currNum = i * multiple;
                    while (currNum < limit + 1)
                    {
                        sieve[currNum] = true;
                        multiple++;
                        currNum = i * multiple;
                    }
                }
            }

            List<int> primeNumbers = new List<int>();
            for (int i = 2; i < sieve.Length; i++)
            {
                if (!sieve[i])
                {
                    primeNumbers.Add(item: i);
                }
            }

            return primeNumbers;
        }

        public static bool IsItPrime(int number)
        {
            if (number == 2 || number == 3)
            {
                return true;
            }

            if (number <= 1 || number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i++)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int> FindProperDivisorsOf(int number)
        {
            List<int> properDivisors = new List<int>();
            properDivisors.Add(item: 1);
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    properDivisors.Add(item: i);
                }
            }

            return properDivisors;
        }

        public static List<int> FindDivisorsOf(int number)
        {
            List<int> divisors = new List<int>();
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(item: i);
                }
            }
            divisors.Add(item: number);
            return divisors;
        }

        public static int GetDecimalLength(int numerator, int denominator)
        {
            int length = 0;
            int remainder = int.MinValue;
            HashSet<Fraction> divisions = new HashSet<Fraction>();
            while (remainder != 0)
            {
                bool alreadyIncreasedLength = false;
                while (denominator > numerator)
                {
                    length++;
                    numerator *= 10;
                    alreadyIncreasedLength = true;
                }

                Fraction thisOperation = new Fraction(numerator: numerator, denominator: denominator);
                if (divisions.Contains(item: thisOperation))
                {
                    // Cycle detected.
                    return length - 1;
                }
                else
                {
                    // No cycle detected.
                    divisions.Add(item: thisOperation);
                }

                int quotient = numerator / denominator;
                remainder = numerator % denominator;
                if (!alreadyIncreasedLength)
                {
                    length++;
                }

                else
                {
                    numerator = remainder;
                }
            }
            return length;
        }

        public static int GetLengthOfReciprocalCycle(int numerator, int denominator)
        {
            int length = 0;
            int remainder = int.MinValue;
            bool cycleDetected = false;
            HashSet<Fraction> divisions = new HashSet<Fraction>();
            while (remainder != 0)
            {
                bool alreadyIncreasedLength = false;
                while (denominator > numerator)
                {
                    length++;
                    numerator *= 10;
                    alreadyIncreasedLength = true;
                }

                Fraction thisOperation = new Fraction(numerator: numerator, denominator: denominator);
                if (divisions.Contains(item: thisOperation))
                {
                    // Cycle detected.
                    if (!cycleDetected)
                    {
                        cycleDetected = true;
                        divisions.Clear();
                        length = 0;
                    }
                    else
                    {
                        return length - 1;
                    }
                }
                else
                {
                    // No cycle detected.
                    divisions.Add(item: thisOperation);
                }

                int quotient = numerator / denominator;
                remainder = numerator % denominator;
                if (!alreadyIncreasedLength)
                {
                    length++;
                }

                else
                {
                    numerator = remainder;
                }
            }
            return length;
        }

        public static List<int> GetDigits(int value)
        {
            List<int> digits = new List<int>();
            while (value > 0)
            {
                digits.Add(item: value % 10);
                value /= 10;
            }

            return digits;
        }

        public static List<int> GetDigits(BigInteger value)
        {
            var numericString = value.ToString();
            var digitsList = Array.ConvertAll(numericString.ToCharArray(), c => (int)Char.GetNumericValue(c)).ToList();
            return digitsList;
        }

        public static int GetNumberOfDigits(int value)
        {
            return (int)System.Math.Floor(System.Math.Log10(value) + 1);
        }

        public static int GetNumberOfDigits(long value)
        {
            return (int)System.Math.Floor(System.Math.Log10(value) + 1);
        }

        public static int GetNumberOfDigits(BigInteger value)
        {
            return value.ToString().Length;
        }

        public static int CalculateFactorial(int value)
        {
            int factorial = 1;
            for (int i = 2; i <= value; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static bool IsItAPalindrome(int value)
        {
            if (value < 10 && value >= 0)
            {
                return true;
            }
            int digitsCount = SharedCode.Math.GetNumberOfDigits(value: value);
            Stack<int> digits = new Stack<int>(capacity: digitsCount / 2);
            for (int i = 0; i < digitsCount / 2; i++)
            {
                int digitToPush = value % 10;
                digits.Push(item: digitToPush);
                value /= 10;
            }

            if (digitsCount % 2 != 0)
            {
                value /= 10;
            }

            while (value > 0)
            {
                int digitToCheck = value % 10;
                if (digits.Pop() != digitToCheck)
                {
                    return false;
                }

                value /= 10;
            }

            return true;
        }

        public static bool IsItAPalindrome(long value)
        {
            int digitsCount = SharedCode.Math.GetNumberOfDigits(value: value);
            Stack<int> digits = new Stack<int>(capacity: digitsCount / 2);
            for (int i = 0; i < digitsCount / 2; i++)
            {
                int digitToPush = (int)(value % 10);
                digits.Push(item: digitToPush);
                value /= 10;
            }

            if (digitsCount % 2 != 0)
            {
                value /= 10;
            }

            while (value > 0)
            {
                int digitToCheck = (int)(value % 10);
                if (digits.Pop() != digitToCheck)
                {
                    return false;
                }

                value /= 10;
            }

            return true;
        }

        public static bool IsItAPalindrome(BigInteger value)
        {
            return SharedCode.Strings.IsItAPalindrome(s: value.ToString());
        }

        public static bool ContainsDigit(int testValue, int digit)
        {
            while (testValue > 0)
            {
                int testDigit = testValue % 10;
                if (testDigit == digit)
                {
                    return true;
                }

                testValue /= 10;
            }

            return false;
        }

        public static bool IsItAnInteger(double testValue)
        {
            return testValue % 1 == 0;
        }

        public static int GetDigitAtIndex(int number, int digit)
        {
            // Get the number of digits in number.
            // int i = 1 to track the currentDigit we're at.
            // divide by 10 and increment i each time until i < number of digits + 1 - digit

            int numberOfDigitsInNumber = ProjectEuler.SharedCode.Math.GetNumberOfDigits(value: number);

            int i = 1;
            while (i < numberOfDigitsInNumber + 1 - digit)
            {
                number /= 10;
                i++;
            }

            int digitToReturn = number % 10;
            return digitToReturn;
        }

        public static int GetDigitAtIndex(long number, int digit)
        {
            // Get the number of digits in number.
            // int i = 1 to track the currentDigit we're at.
            // divide by 10 and increment i each time until i < number of digits + 1 - digit

            int numberOfDigitsInNumber = ProjectEuler.SharedCode.Math.GetNumberOfDigits(value: number);

            int i = 1;
            while (i < numberOfDigitsInNumber + 1 - digit)
            {
                number /= 10;
                i++;
            }

            int digitToReturn = (int)(number % 10);
            return digitToReturn;
        }

        public static bool IsItPandigital(int number)
        {
            HashSet<int> digitsAccountedFor = new HashSet<int>();
            while (number > 0)
            {
                int digitToAdd = number % 10;
                if (digitToAdd == 0 || digitsAccountedFor.Contains(item: digitToAdd))
                {
                    return false;
                }

                digitsAccountedFor.Add(digitToAdd);
                number /= 10;
            }
            for (int i = 1; i <= digitsAccountedFor.Count; i++)
            {
                if (!digitsAccountedFor.Contains(item: i))
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetSubString(int number, int startDigit, int endDigit)
        {
            int numberOfDigits = SharedCode.Math.GetNumberOfDigits(value: number);
            int returnNumber = number % (int)System.Math.Pow(x: 10, y: numberOfDigits + 1 - startDigit);
            returnNumber /= (int)System.Math.Pow(x: 10, y: numberOfDigits - endDigit);
            return returnNumber;
        }

        public static BigInteger ReverseNumber(BigInteger number)
        {
            string reversedNumber = new String(number.ToString().ToCharArray().Reverse().ToArray());
            return BigInteger.Parse(reversedNumber);
        }
    }
}
