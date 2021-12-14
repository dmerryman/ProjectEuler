using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests.SharedCodeTests
{
    /// <summary>
    /// Summary description for MathTests
    /// </summary>
    [TestClass]
    public class MathTests
    {
        public MathTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void IsItPrime()
        {
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItPrime(number: 5));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItPrime(number: 7));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItPrime(number: 13));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItPrime(number: 29));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItPrime(number: 6857));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItPrime(number: 9973));
            Assert.IsFalse(ProjectEuler.SharedCode.Math.IsItPrime(number: 6858));
            Assert.IsFalse(ProjectEuler.SharedCode.Math.IsItPrime(number: 500));
        }

        [TestMethod]
        public void TestFindProperDivisorsOf()
        {
            Assert.AreEqual(110, ProjectEuler.SharedCode.Math.FindProperDivisorsOf(220)[10]);
            Assert.AreEqual(11, ProjectEuler.SharedCode.Math.FindProperDivisorsOf(220).Count);
        }

        //[TestMethod]
        //public void TestGetDecimalLengthOfNonRepeatingFraction()
        //{
        //    Assert.AreEqual(1,
        //        ProjectEuler.SharedCode.Math.GetDecimalLengthOfNonRepeatingFraction(numerator: 1, denominator: 2));
        //    Assert.AreEqual(1,
        //        ProjectEuler.SharedCode.Math.GetDecimalLengthOfNonRepeatingFraction(numerator: 4, denominator: 8));
        //    Assert.AreEqual(2,
        //        ProjectEuler.SharedCode.Math.GetDecimalLengthOfNonRepeatingFraction(numerator: 1, denominator: 4));
        //    Assert.AreEqual(3,
        //        ProjectEuler.SharedCode.Math.GetDecimalLengthOfNonRepeatingFraction(numerator: 1, denominator: 8));
        //    Assert.AreEqual(4,
        //        ProjectEuler.SharedCode.Math.GetDecimalLengthOfNonRepeatingFraction(numerator: 1, denominator: 16));
        //}

        [TestMethod]
        public void TestGetDecimalLength()
        {
            Assert.AreEqual(1,
                ProjectEuler.SharedCode.Math.GetDecimalLength(numerator: 1, denominator: 2));
            Assert.AreEqual(1,
                ProjectEuler.SharedCode.Math.GetDecimalLength(numerator: 1, denominator: 3));
            Assert.AreEqual(2,
                ProjectEuler.SharedCode.Math.GetDecimalLength(numerator: 1, denominator: 6));
        }

        [TestMethod]
        public void TestGetLengthOfReciprocalCycle()
        {
            Assert.AreEqual(1, ProjectEuler.SharedCode.Math.GetLengthOfReciprocalCycle(numerator:1, denominator: 3));
            Assert.AreEqual(6, ProjectEuler.SharedCode.Math.GetLengthOfReciprocalCycle(numerator: 1, denominator: 7));
        }

        [TestMethod]
        public void TestGetDigits()
        {
            Assert.AreEqual(4, ProjectEuler.SharedCode.Math.GetDigits(1234).Count);
            Assert.AreEqual(4, ProjectEuler.SharedCode.Math.GetDigits(1111).Count);
        }

        [TestMethod]
        public void TestCalculateFactorial()
        {
            Assert.AreEqual(362880, ProjectEuler.SharedCode.Math.CalculateFactorial(value: 9));
        }

        [TestMethod]
        public void TestIsItAPalindrome()
        {
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItAPalindrome(value: 1551));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItAPalindrome(value: 15251));
            Assert.IsFalse(ProjectEuler.SharedCode.Math.IsItAPalindrome(value: 12345));
            Assert.IsTrue(ProjectEuler.SharedCode.Math.IsItAPalindrome(value: 123456789987654321));
        }

        [TestMethod]
        public void TestContainsDigit()
        {
            Assert.IsTrue(ProjectEuler.SharedCode.Math.ContainsDigit(testValue: 123456789, digit: 1));
            Assert.IsFalse(ProjectEuler.SharedCode.Math.ContainsDigit(testValue: 23456789, digit: 1));
        }
    }
}
